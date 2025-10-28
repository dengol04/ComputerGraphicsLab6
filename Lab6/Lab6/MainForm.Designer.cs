namespace PlatonicSolids
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbTranslateX = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTranslateY = new System.Windows.Forms.TrackBar();
            this.tbTranslateZ = new System.Windows.Forms.TrackBar();
            this.lblTranslateY = new System.Windows.Forms.Label();
            this.lblTranslateZ = new System.Windows.Forms.Label();
            this.lblTranslateX = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudScaleCenter = new System.Windows.Forms.NumericUpDown();
            this.btnScaleCenter = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbReflectionPlane = new System.Windows.Forms.ComboBox();
            this.btnReflect = new System.Windows.Forms.Button();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.tbRotateZ = new System.Windows.Forms.TrackBar();
            this.tbRotateY = new System.Windows.Forms.TrackBar();
            this.tbRotateX = new System.Windows.Forms.TrackBar();
            this.lblRotateY = new System.Windows.Forms.Label();
            this.lblRotateZ = new System.Windows.Forms.Label();
            this.lblRotateX = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTranslateX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTranslateY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTranslateZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScaleCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRotateZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRotateY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRotateX)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1131, 24);
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
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
            this.projectionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.tetrahedronToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tetrahedronToolStripMenuItem.Text = "Tetrahedron";
            this.tetrahedronToolStripMenuItem.Click += new System.EventHandler(this.tetrahedronToolStripMenuItem_Click);
            // 
            // hexahedronToolStripMenuItem
            // 
            this.hexahedronToolStripMenuItem.Name = "hexahedronToolStripMenuItem";
            this.hexahedronToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hexahedronToolStripMenuItem.Text = "Hexahedron";
            this.hexahedronToolStripMenuItem.Click += new System.EventHandler(this.hexahedronToolStripMenuItem_Click);
            // 
            // octahedronToolStripMenuItem
            // 
            this.octahedronToolStripMenuItem.Name = "octahedronToolStripMenuItem";
            this.octahedronToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.octahedronToolStripMenuItem.Text = "Octahedron";
            this.octahedronToolStripMenuItem.Click += new System.EventHandler(this.octahedronToolStripMenuItem_Click);
            // 
            // icosahedronToolStripMenuItem
            // 
            this.icosahedronToolStripMenuItem.Name = "icosahedronToolStripMenuItem";
            this.icosahedronToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.icosahedronToolStripMenuItem.Text = "Icosahedron";
            this.icosahedronToolStripMenuItem.Click += new System.EventHandler(this.icosahedronToolStripMenuItem_Click);
            // 
            // dodecahedronToolStripMenuItem
            // 
            this.dodecahedronToolStripMenuItem.Name = "dodecahedronToolStripMenuItem";
            this.dodecahedronToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodecahedronToolStripMenuItem.Text = "Dodecahedron";
            this.dodecahedronToolStripMenuItem.Click += new System.EventHandler(this.dodecahedronToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(792, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Смешение X:";
            // 
            // tbTranslateX
            // 
            this.tbTranslateX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTranslateX.BackColor = System.Drawing.Color.DimGray;
            this.tbTranslateX.LargeChange = 1;
            this.tbTranslateX.Location = new System.Drawing.Point(795, 30);
            this.tbTranslateX.Maximum = 5;
            this.tbTranslateX.Minimum = -5;
            this.tbTranslateX.Name = "tbTranslateX";
            this.tbTranslateX.Size = new System.Drawing.Size(104, 45);
            this.tbTranslateX.TabIndex = 2;
            this.tbTranslateX.Scroll += new System.EventHandler(this.tbTranslate_Scroll);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1012, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Смешение Z:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(902, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Смешение Y:";
            // 
            // tbTranslateY
            // 
            this.tbTranslateY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTranslateY.BackColor = System.Drawing.Color.DimGray;
            this.tbTranslateY.LargeChange = 1;
            this.tbTranslateY.Location = new System.Drawing.Point(905, 30);
            this.tbTranslateY.Maximum = 5;
            this.tbTranslateY.Minimum = -5;
            this.tbTranslateY.Name = "tbTranslateY";
            this.tbTranslateY.Size = new System.Drawing.Size(104, 45);
            this.tbTranslateY.TabIndex = 5;
            this.tbTranslateY.Scroll += new System.EventHandler(this.tbTranslate_Scroll);
            // 
            // tbTranslateZ
            // 
            this.tbTranslateZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTranslateZ.BackColor = System.Drawing.Color.DimGray;
            this.tbTranslateZ.LargeChange = 1;
            this.tbTranslateZ.Location = new System.Drawing.Point(1015, 30);
            this.tbTranslateZ.Maximum = 5;
            this.tbTranslateZ.Minimum = -5;
            this.tbTranslateZ.Name = "tbTranslateZ";
            this.tbTranslateZ.Size = new System.Drawing.Size(104, 45);
            this.tbTranslateZ.TabIndex = 6;
            this.tbTranslateZ.Scroll += new System.EventHandler(this.tbTranslate_Scroll);
            // 
            // lblTranslateY
            // 
            this.lblTranslateY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTranslateY.AutoSize = true;
            this.lblTranslateY.Location = new System.Drawing.Point(981, 9);
            this.lblTranslateY.Name = "lblTranslateY";
            this.lblTranslateY.Size = new System.Drawing.Size(13, 13);
            this.lblTranslateY.TabIndex = 9;
            this.lblTranslateY.Text = "0";
            // 
            // lblTranslateZ
            // 
            this.lblTranslateZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTranslateZ.AutoSize = true;
            this.lblTranslateZ.Location = new System.Drawing.Point(1091, 9);
            this.lblTranslateZ.Name = "lblTranslateZ";
            this.lblTranslateZ.Size = new System.Drawing.Size(13, 13);
            this.lblTranslateZ.TabIndex = 8;
            this.lblTranslateZ.Text = "0";
            // 
            // lblTranslateX
            // 
            this.lblTranslateX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTranslateX.AutoSize = true;
            this.lblTranslateX.Location = new System.Drawing.Point(871, 9);
            this.lblTranslateX.Name = "lblTranslateX";
            this.lblTranslateX.Size = new System.Drawing.Size(13, 13);
            this.lblTranslateX.TabIndex = 7;
            this.lblTranslateX.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Масштаб";
            // 
            // nudScaleCenter
            // 
            this.nudScaleCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudScaleCenter.DecimalPlaces = 2;
            this.nudScaleCenter.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudScaleCenter.Location = new System.Drawing.Point(377, 30);
            this.nudScaleCenter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudScaleCenter.Name = "nudScaleCenter";
            this.nudScaleCenter.Size = new System.Drawing.Size(82, 20);
            this.nudScaleCenter.TabIndex = 11;
            this.nudScaleCenter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnScaleCenter
            // 
            this.btnScaleCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScaleCenter.BackColor = System.Drawing.Color.DimGray;
            this.btnScaleCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScaleCenter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnScaleCenter.Location = new System.Drawing.Point(376, 56);
            this.btnScaleCenter.Name = "btnScaleCenter";
            this.btnScaleCenter.Size = new System.Drawing.Size(82, 23);
            this.btnScaleCenter.TabIndex = 12;
            this.btnScaleCenter.Text = "Применить";
            this.btnScaleCenter.UseVisualStyleBackColor = false;
            this.btnScaleCenter.Click += new System.EventHandler(this.btnScaleCenter_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Отразить";
            // 
            // cmbReflectionPlane
            // 
            this.cmbReflectionPlane.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbReflectionPlane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReflectionPlane.FormattingEnabled = true;
            this.cmbReflectionPlane.Items.AddRange(new object[] {
            "XY ",
            "XZ ",
            "YZ"});
            this.cmbReflectionPlane.Location = new System.Drawing.Point(287, 29);
            this.cmbReflectionPlane.Name = "cmbReflectionPlane";
            this.cmbReflectionPlane.Size = new System.Drawing.Size(83, 21);
            this.cmbReflectionPlane.TabIndex = 14;
            // 
            // btnReflect
            // 
            this.btnReflect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReflect.BackColor = System.Drawing.Color.DimGray;
            this.btnReflect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReflect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReflect.Location = new System.Drawing.Point(287, 56);
            this.btnReflect.Name = "btnReflect";
            this.btnReflect.Size = new System.Drawing.Size(83, 23);
            this.btnReflect.TabIndex = 15;
            this.btnReflect.Text = "Отразить";
            this.btnReflect.UseVisualStyleBackColor = false;
            this.btnReflect.Click += new System.EventHandler(this.btnReflect_Click);
            // 
            // btnResetAll
            // 
            this.btnResetAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetAll.BackColor = System.Drawing.Color.DimGray;
            this.btnResetAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetAll.Location = new System.Drawing.Point(206, 30);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(75, 23);
            this.btnResetAll.TabIndex = 16;
            this.btnResetAll.Text = "Сбросить";
            this.btnResetAll.UseVisualStyleBackColor = false;
            this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
            // 
            // tbRotateZ
            // 
            this.tbRotateZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRotateZ.BackColor = System.Drawing.Color.DimGray;
            this.tbRotateZ.LargeChange = 1;
            this.tbRotateZ.Location = new System.Drawing.Point(684, 30);
            this.tbRotateZ.Maximum = 180;
            this.tbRotateZ.Minimum = -180;
            this.tbRotateZ.Name = "tbRotateZ";
            this.tbRotateZ.Size = new System.Drawing.Size(104, 45);
            this.tbRotateZ.TabIndex = 19;
            this.tbRotateZ.TickFrequency = 30;
            this.tbRotateZ.Scroll += new System.EventHandler(this.tbRotate_Scroll);
            // 
            // tbRotateY
            // 
            this.tbRotateY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRotateY.BackColor = System.Drawing.Color.DimGray;
            this.tbRotateY.LargeChange = 1;
            this.tbRotateY.Location = new System.Drawing.Point(574, 30);
            this.tbRotateY.Maximum = 180;
            this.tbRotateY.Minimum = -180;
            this.tbRotateY.Name = "tbRotateY";
            this.tbRotateY.Size = new System.Drawing.Size(104, 45);
            this.tbRotateY.TabIndex = 18;
            this.tbRotateY.TickFrequency = 30;
            this.tbRotateY.Scroll += new System.EventHandler(this.tbRotate_Scroll);
            // 
            // tbRotateX
            // 
            this.tbRotateX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRotateX.BackColor = System.Drawing.Color.DimGray;
            this.tbRotateX.LargeChange = 1;
            this.tbRotateX.Location = new System.Drawing.Point(464, 30);
            this.tbRotateX.Maximum = 180;
            this.tbRotateX.Minimum = -180;
            this.tbRotateX.Name = "tbRotateX";
            this.tbRotateX.Size = new System.Drawing.Size(104, 45);
            this.tbRotateX.TabIndex = 17;
            this.tbRotateX.TickFrequency = 30;
            this.tbRotateX.Scroll += new System.EventHandler(this.tbRotate_Scroll);
            // 
            // lblRotateY
            // 
            this.lblRotateY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRotateY.AutoSize = true;
            this.lblRotateY.Location = new System.Drawing.Point(640, 9);
            this.lblRotateY.Name = "lblRotateY";
            this.lblRotateY.Size = new System.Drawing.Size(13, 13);
            this.lblRotateY.TabIndex = 25;
            this.lblRotateY.Text = "0";
            // 
            // lblRotateZ
            // 
            this.lblRotateZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRotateZ.AutoSize = true;
            this.lblRotateZ.Location = new System.Drawing.Point(750, 9);
            this.lblRotateZ.Name = "lblRotateZ";
            this.lblRotateZ.Size = new System.Drawing.Size(13, 13);
            this.lblRotateZ.TabIndex = 24;
            this.lblRotateZ.Text = "0";
            // 
            // lblRotateX
            // 
            this.lblRotateX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRotateX.AutoSize = true;
            this.lblRotateX.Location = new System.Drawing.Point(530, 9);
            this.lblRotateX.Name = "lblRotateX";
            this.lblRotateX.Size = new System.Drawing.Size(13, 13);
            this.lblRotateX.TabIndex = 23;
            this.lblRotateX.Text = "0";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(571, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Поворот Y:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(681, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Поворот Z:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(461, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Поворот X:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 600);
            this.Controls.Add(this.lblRotateY);
            this.Controls.Add(this.lblRotateZ);
            this.Controls.Add(this.lblRotateX);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbRotateZ);
            this.Controls.Add(this.tbRotateY);
            this.Controls.Add(this.tbRotateX);
            this.Controls.Add(this.btnResetAll);
            this.Controls.Add(this.btnReflect);
            this.Controls.Add(this.cmbReflectionPlane);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnScaleCenter);
            this.Controls.Add(this.nudScaleCenter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTranslateY);
            this.Controls.Add(this.lblTranslateZ);
            this.Controls.Add(this.lblTranslateX);
            this.Controls.Add(this.tbTranslateZ);
            this.Controls.Add(this.tbTranslateY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTranslateX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Platonic Solids Viewer";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTranslateX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTranslateY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTranslateZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScaleCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRotateZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRotateY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRotateX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbTranslateX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbTranslateY;
        private System.Windows.Forms.TrackBar tbTranslateZ;
        private System.Windows.Forms.Label lblTranslateY;
        private System.Windows.Forms.Label lblTranslateZ;
        private System.Windows.Forms.Label lblTranslateX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudScaleCenter;
        private System.Windows.Forms.Button btnScaleCenter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbReflectionPlane;
        private System.Windows.Forms.Button btnReflect;
        private System.Windows.Forms.Button btnResetAll;
        private System.Windows.Forms.TrackBar tbRotateZ;
        private System.Windows.Forms.TrackBar tbRotateY;
        private System.Windows.Forms.TrackBar tbRotateX;
        private System.Windows.Forms.Label lblRotateY;
        private System.Windows.Forms.Label lblRotateZ;
        private System.Windows.Forms.Label lblRotateX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}