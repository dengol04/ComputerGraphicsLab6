using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PlatonicSolids
{
    public partial class MainForm : Form
    {
        private Polyhedron currentPolyhedron;
        private string projectionType = "Perspective";
        private const double ROTATION_ANGLE_X = 0.5;
        private const double ROTATION_ANGLE_Y = 0.5;

        private Polyhedron originalPolyhedron;
        private double translateX = 0, translateY = 0, translateZ = 0;
        private double rotationX = 0, rotationY = 0, rotationZ = 0;

        public MainForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            LoadModel(Polyhedron.CreateTetrahedron());
        }

        private void LoadModel(Polyhedron model)
        {
            originalPolyhedron = model;
            ResetAllStateAndUI();
        }

        private void ResetAllStateAndUI()
        {
            translateX = translateY = translateZ = 0;
            rotationX = rotationY = rotationZ = 0;

            tbTranslateX.Value = 0;
            tbTranslateY.Value = 0;
            tbTranslateZ.Value = 0;
            lblTranslateX.Text = "0";
            lblTranslateY.Text = "0";
            lblTranslateZ.Text = "0";

            tbRotateX.Value = 0;
            tbRotateY.Value = 0;
            tbRotateZ.Value = 0;
            lblRotateX.Text = "0°";
            lblRotateY.Text = "0°";
            lblRotateZ.Text = "0°";

            nudScaleCenter.Value = 1;
            cmbReflectionPlane.SelectedIndex = -1;

            ApplyAllTransformations();
        }

        private void ApplyAllTransformations()
        {
            if (originalPolyhedron == null) return;

            currentPolyhedron = ClonePolyhedron(originalPolyhedron);

            double radX = rotationX * Math.PI / 180.0;
            double radY = rotationY * Math.PI / 180.0;
            double radZ = rotationZ * Math.PI / 180.0;

            var translationMatrix = Matrix4x4.CreateTranslation(translateX, translateY, translateZ);
            var rotXMatrix = Matrix4x4.CreateRotationX(radX);
            var rotYMatrix = Matrix4x4.CreateRotationY(radY);
            var rotZMatrix = Matrix4x4.CreateRotationZ(radZ);

            var rotationMatrix = Matrix4x4.Multiply(rotZMatrix, Matrix4x4.Multiply(rotYMatrix, rotXMatrix));
            var finalTransform = Matrix4x4.Multiply(translationMatrix, rotationMatrix);

            currentPolyhedron.ApplyTransform(finalTransform);

            this.Invalidate();
        }

        private Polyhedron ClonePolyhedron(Polyhedron source)
        {
            var vertices = source.Vertices.Select(v => new Vector3(v.X, v.Y, v.Z)).ToList();
            var polygons = new List<Polygon>(source.Polygons);
            return new Polyhedron(vertices, polygons);
        }

        private void tbTranslate_Scroll(object sender, EventArgs e)
        {
            translateX = tbTranslateX.Value;
            translateY = tbTranslateY.Value;
            translateZ = tbTranslateZ.Value;

            lblTranslateX.Text = translateX.ToString();
            lblTranslateY.Text = translateY.ToString();
            lblTranslateZ.Text = translateZ.ToString();

            ApplyAllTransformations();
        }

        private void tbRotate_Scroll(object sender, EventArgs e)
        {
            rotationX = tbRotateX.Value;
            rotationY = tbRotateY.Value;
            rotationZ = tbRotateZ.Value;

            lblRotateX.Text = rotationX.ToString();
            lblRotateY.Text = rotationY.ToString();
            lblRotateZ.Text = rotationZ.ToString();

            ApplyAllTransformations();
        }

        private void btnScaleCenter_Click(object sender, EventArgs e)
        {
            double factor = (double)nudScaleCenter.Value;

            Vector3 center = originalPolyhedron.GetCenter();
            var toOrigin = Matrix4x4.CreateTranslation(-center.X, -center.Y, -center.Z);
            var scale = Matrix4x4.CreateScale(factor, factor, factor);
            var fromOrigin = Matrix4x4.CreateTranslation(center.X, center.Y, center.Z);
            var transformMatrix = Matrix4x4.Multiply(fromOrigin, Matrix4x4.Multiply(scale, toOrigin));

            originalPolyhedron.ApplyTransform(transformMatrix);
            ApplyAllTransformations();
        }

        private void btnReflect_Click(object sender, EventArgs e)
        {
            string selectedPlane = cmbReflectionPlane.SelectedItem.ToString();
            var reflectionMatrix = Matrix4x4.CreateReflection(selectedPlane);

            originalPolyhedron.ApplyTransform(reflectionMatrix);
            ApplyAllTransformations();
        }

        private void btnResetAll_Click(object sender, EventArgs e)
        {
            var currentModelName = originalPolyhedron.Polygons.Count; 
            switch (currentModelName)
            {
                case 4: LoadModel(Polyhedron.CreateTetrahedron()); break;
                case 6: LoadModel(Polyhedron.CreateHexahedron()); break;
                case 8: LoadModel(Polyhedron.CreateOctahedron()); break;
                case 20: LoadModel(Polyhedron.CreateIcosahedron()); break;
                case 12: LoadModel(Polyhedron.CreateDodecahedron()); break;
                default: LoadModel(Polyhedron.CreateTetrahedron()); break;
            }
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.Black);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (currentPolyhedron == null) return;

            int width = ClientSize.Width;
            int height = ClientSize.Height;
            double scale = Math.Min(width, height) / 5.0;

            foreach (var polygon in currentPolyhedron.Polygons)
            {
                PointF[] points = new PointF[polygon.Indices.Length];
                for (int i = 0; i < polygon.Indices.Length; i++)
                {
                    Vector3 v = currentPolyhedron.Vertices[polygon.Indices[i]];

                    v = RotateX(v, ROTATION_ANGLE_X);
                    v = RotateY(v, ROTATION_ANGLE_Y);

                    PointF p;
                    if (projectionType == "Perspective")
                    {
                        p = ProjectPerspective(v, width, height, scale);
                    }
                    else
                    {
                        p = ProjectAxonometric(v, width, height, scale);
                    }
                    points[i] = p;
                }
                g.DrawPolygon(Pens.White, points);
            }
        }

        private Vector3 RotateX(Vector3 v, double angle)
        {
            double cos = Math.Cos(angle);
            double sin = Math.Sin(angle);
            return new Vector3(v.X, v.Y * cos - v.Z * sin, v.Y * sin + v.Z * cos);
        }

        private Vector3 RotateY(Vector3 v, double angle)
        {
            double cos = Math.Cos(angle);
            double sin = Math.Sin(angle);
            return new Vector3(v.X * cos + v.Z * sin, v.Y, -v.X * sin + v.Z * cos);
        }

        private PointF ProjectPerspective(Vector3 v, int width, int height, double scale)
        {
            double distance = 5;
            double f = distance / (distance - v.Z);
            double x = v.X * f * scale + width / 2;
            double y = -v.Y * f * scale + height / 2;
            return new PointF((float)x, (float)y);
        }

        private PointF ProjectAxonometric(Vector3 v, int width, int height, double scale)
        {
            double x = v.X * scale + width / 2;
            double y = -v.Y * scale + height / 2;
            return new PointF((float)x, (float)y);
        }

        private void perspectiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            projectionType = "Perspective";
            perspectiveToolStripMenuItem.Checked = true;
            axonometricToolStripMenuItem.Checked = false;
            this.Invalidate();
        }

        private void axonometricToolStripMenuItem_Click(object sender, EventArgs e)
        {
            projectionType = "Axonometric";
            perspectiveToolStripMenuItem.Checked = false;
            axonometricToolStripMenuItem.Checked = true;
            this.Invalidate();
        }

        private void tetrahedronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadModel(Polyhedron.CreateTetrahedron());
        }

        private void hexahedronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadModel(Polyhedron.CreateHexahedron());
        }

        private void octahedronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadModel(Polyhedron.CreateOctahedron());
        }

        private void icosahedronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadModel(Polyhedron.CreateIcosahedron());
        }

        private void dodecahedronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadModel(Polyhedron.CreateDodecahedron());
        }
    }
}