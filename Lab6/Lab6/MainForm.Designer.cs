﻿namespace PlatonicSolids
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perspectiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem axonometricToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tetrahedronToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hexahedronToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem octahedronToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem icosahedronToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodecahedronToolStripMenuItem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perspectiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.axonometricToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tetrahedronToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexahedronToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.octahedronToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.icosahedronToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodecahedronToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.modelsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += (s, e) => this.Close();
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectionToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // projectionToolStripMenuItem
            // 
            this.projectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perspectiveToolStripMenuItem,
            this.axonometricToolStripMenuItem});
            this.projectionToolStripMenuItem.Name = "projectionToolStripMenuItem";
            this.projectionToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.projectionToolStripMenuItem.Text = "Projection";
            // 
            // perspectiveToolStripMenuItem
            // 
            this.perspectiveToolStripMenuItem.Checked = true;
            this.perspectiveToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.perspectiveToolStripMenuItem.Name = "perspectiveToolStripMenuItem";
            this.perspectiveToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.perspectiveToolStripMenuItem.Text = "Perspective";
            this.perspectiveToolStripMenuItem.Click += new System.EventHandler(this.perspectiveToolStripMenuItem_Click);
            // 
            // axonometricToolStripMenuItem
            // 
            this.axonometricToolStripMenuItem.Name = "axonometricToolStripMenuItem";
            this.axonometricToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.axonometricToolStripMenuItem.Text = "Axonometric";
            this.axonometricToolStripMenuItem.Click += new System.EventHandler(this.axonometricToolStripMenuItem_Click);
            // 
            // modelsToolStripMenuItem
            // 
            this.modelsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tetrahedronToolStripMenuItem,
            this.hexahedronToolStripMenuItem,
            this.octahedronToolStripMenuItem,
            this.icosahedronToolStripMenuItem,
            this.dodecahedronToolStripMenuItem});
            this.modelsToolStripMenuItem.Name = "modelsToolStripMenuItem";
            this.modelsToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.modelsToolStripMenuItem.Text = "Models";
            // 
            // tetrahedronToolStripMenuItem
            // 
            this.tetrahedronToolStripMenuItem.Name = "tetrahedronToolStripMenuItem";
            this.tetrahedronToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.tetrahedronToolStripMenuItem.Text = "Tetrahedron";
            this.tetrahedronToolStripMenuItem.Click += new System.EventHandler(this.tetrahedronToolStripMenuItem_Click);
            // 
            // hexahedronToolStripMenuItem
            // 
            this.hexahedronToolStripMenuItem.Name = "hexahedronToolStripMenuItem";
            this.hexahedronToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.hexahedronToolStripMenuItem.Text = "Hexahedron";
            this.hexahedronToolStripMenuItem.Click += new System.EventHandler(this.hexahedronToolStripMenuItem_Click);
            // 
            // octahedronToolStripMenuItem
            // 
            this.octahedronToolStripMenuItem.Name = "octahedronToolStripMenuItem";
            this.octahedronToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.octahedronToolStripMenuItem.Text = "Octahedron";
            this.octahedronToolStripMenuItem.Click += new System.EventHandler(this.octahedronToolStripMenuItem_Click);
            // 
            // icosahedronToolStripMenuItem
            // 
            this.icosahedronToolStripMenuItem.Name = "icosahedronToolStripMenuItem";
            this.icosahedronToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.icosahedronToolStripMenuItem.Text = "Icosahedron";
            this.icosahedronToolStripMenuItem.Click += new System.EventHandler(this.icosahedronToolStripMenuItem_Click);
            // 
            // dodecahedronToolStripMenuItem
            // 
            this.dodecahedronToolStripMenuItem.Name = "dodecahedronToolStripMenuItem";
            this.dodecahedronToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.dodecahedronToolStripMenuItem.Text = "Dodecahedron";
            this.dodecahedronToolStripMenuItem.Click += new System.EventHandler(this.dodecahedronToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Platonic Solids Viewer";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}