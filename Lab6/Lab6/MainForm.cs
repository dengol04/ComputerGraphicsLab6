﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace PlatonicSolids
{
    public partial class MainForm : Form
    {
        private Polyhedron currentPolyhedron;
        private string projectionType = "Perspective";
        private const double ROTATION_ANGLE_X = 0.5;
        private const double ROTATION_ANGLE_Y = 0.5;

        public MainForm()
        {
            InitializeComponent();
            currentPolyhedron = Polyhedron.CreateTetrahedron();
            this.DoubleBuffered = true;
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
            double y = v.Y * f * scale + height / 2;
            return new PointF((float)x, (float)y);
        }

        private PointF ProjectAxonometric(Vector3 v, int width, int height, double scale)
        {
            double x = v.X * scale + width / 2;
            double y = v.Y * scale + height / 2;
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
            currentPolyhedron = Polyhedron.CreateTetrahedron();
            this.Invalidate();
        }

        private void hexahedronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPolyhedron = Polyhedron.CreateHexahedron();
            this.Invalidate();
        }

        private void octahedronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPolyhedron = Polyhedron.CreateOctahedron();
            this.Invalidate();
        }

        private void icosahedronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPolyhedron = Polyhedron.CreateIcosahedron();
            this.Invalidate();
        }

        private void dodecahedronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPolyhedron = Polyhedron.CreateDodecahedron();
            this.Invalidate();
        }
    }
}