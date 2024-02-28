namespace vscam
{
    partial class formVsCam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formVsCam));
            this.divNavbar = new System.Windows.Forms.FlowLayoutPanel();
            this.flowInsideNavbarContent = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCamara = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.btnFilters = new System.Windows.Forms.Button();
            this.flowFiltros = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBrightness = new System.Windows.Forms.Button();
            this.btnInvert = new System.Windows.Forms.Button();
            this.btnNoise = new System.Windows.Forms.Button();
            this.btnContrast = new System.Windows.Forms.Button();
            this.btnRgb = new System.Windows.Forms.Button();
            this.btnFlip = new System.Windows.Forms.Button();
            this.btnPixel = new System.Windows.Forms.Button();
            this.btnSharpen = new System.Windows.Forms.Button();
            this.btnBlur = new System.Windows.Forms.Button();
            this.btnEnhance = new System.Windows.Forms.Button();
            this.flowSideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtHistogram = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.tbFilterValue = new System.Windows.Forms.TrackBar();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.flowImageEdited = new System.Windows.Forms.FlowLayoutPanel();
            this.divNavbar.SuspendLayout();
            this.flowFiltros.SuspendLayout();
            this.flowSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFilterValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.flowImageEdited.SuspendLayout();
            this.SuspendLayout();
            // 
            // divNavbar
            // 
            this.divNavbar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.divNavbar.BackColor = System.Drawing.Color.Transparent;
            this.divNavbar.Controls.Add(this.flowInsideNavbarContent);
            this.divNavbar.Controls.Add(this.btnHome);
            this.divNavbar.Controls.Add(this.btnCamara);
            this.divNavbar.Controls.Add(this.btnBack);
            this.divNavbar.Controls.Add(this.btnFile);
            this.divNavbar.Controls.Add(this.btnFilters);
            this.divNavbar.Controls.Add(this.flowFiltros);
            this.divNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.divNavbar.Location = new System.Drawing.Point(0, 0);
            this.divNavbar.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.divNavbar.Name = "divNavbar";
            this.divNavbar.Size = new System.Drawing.Size(916, 42);
            this.divNavbar.TabIndex = 1;
            this.divNavbar.WrapContents = false;
            this.divNavbar.Paint += new System.Windows.Forms.PaintEventHandler(this.divNavbar_Paint);
            // 
            // flowInsideNavbarContent
            // 
            this.flowInsideNavbarContent.AutoSize = true;
            this.flowInsideNavbarContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowInsideNavbarContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.flowInsideNavbarContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowInsideNavbarContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.divNavbar.SetFlowBreak(this.flowInsideNavbarContent, true);
            this.flowInsideNavbarContent.Location = new System.Drawing.Point(3, 3);
            this.flowInsideNavbarContent.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.flowInsideNavbarContent.Name = "flowInsideNavbarContent";
            this.flowInsideNavbarContent.Size = new System.Drawing.Size(2, 2);
            this.flowInsideNavbarContent.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.Transparent;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(5, 3);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(41, 31);
            this.btnHome.TabIndex = 0;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // btnCamara
            // 
            this.btnCamara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCamara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.btnCamara.FlatAppearance.BorderSize = 0;
            this.btnCamara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCamara.ForeColor = System.Drawing.Color.Transparent;
            this.btnCamara.Image = ((System.Drawing.Image)(resources.GetObject("btnCamara.Image")));
            this.btnCamara.Location = new System.Drawing.Point(46, 3);
            this.btnCamara.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnCamara.Name = "btnCamara";
            this.btnCamara.Size = new System.Drawing.Size(42, 31);
            this.btnCamara.TabIndex = 1;
            this.btnCamara.UseVisualStyleBackColor = false;
            this.btnCamara.Click += new System.EventHandler(this.btnCamara_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(88, 3);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(42, 31);
            this.btnBack.TabIndex = 2;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFile
            // 
            this.btnFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.btnFile.FlatAppearance.BorderSize = 0;
            this.btnFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFile.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFile.Location = new System.Drawing.Point(130, 3);
            this.btnFile.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(50, 31);
            this.btnFile.TabIndex = 0;
            this.btnFile.Text = "File";
            this.btnFile.UseVisualStyleBackColor = false;
            // 
            // btnFilters
            // 
            this.btnFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.btnFilters.FlatAppearance.BorderSize = 0;
            this.btnFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilters.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilters.Location = new System.Drawing.Point(180, 3);
            this.btnFilters.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnFilters.Name = "btnFilters";
            this.btnFilters.Size = new System.Drawing.Size(55, 31);
            this.btnFilters.TabIndex = 1;
            this.btnFilters.Text = "Filters";
            this.btnFilters.UseVisualStyleBackColor = false;
            this.btnFilters.Click += new System.EventHandler(this.btnFilters_Click);
            // 
            // flowFiltros
            // 
            this.flowFiltros.BackColor = System.Drawing.Color.Transparent;
            this.flowFiltros.Controls.Add(this.btnBrightness);
            this.flowFiltros.Controls.Add(this.btnInvert);
            this.flowFiltros.Controls.Add(this.btnNoise);
            this.flowFiltros.Controls.Add(this.btnContrast);
            this.flowFiltros.Controls.Add(this.btnRgb);
            this.flowFiltros.Controls.Add(this.btnFlip);
            this.flowFiltros.Controls.Add(this.btnPixel);
            this.flowFiltros.Controls.Add(this.btnSharpen);
            this.flowFiltros.Controls.Add(this.btnBlur);
            this.flowFiltros.Controls.Add(this.btnEnhance);
            this.flowFiltros.Location = new System.Drawing.Point(238, 3);
            this.flowFiltros.Name = "flowFiltros";
            this.flowFiltros.Size = new System.Drawing.Size(635, 34);
            this.flowFiltros.TabIndex = 5;
            this.flowFiltros.Visible = false;
            this.flowFiltros.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // btnBrightness
            // 
            this.btnBrightness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.btnBrightness.FlatAppearance.BorderSize = 0;
            this.btnBrightness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrightness.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrightness.Location = new System.Drawing.Point(0, 0);
            this.btnBrightness.Margin = new System.Windows.Forms.Padding(0);
            this.btnBrightness.Name = "btnBrightness";
            this.btnBrightness.Size = new System.Drawing.Size(79, 31);
            this.btnBrightness.TabIndex = 2;
            this.btnBrightness.Text = "Brightness";
            this.btnBrightness.UseVisualStyleBackColor = false;
            // 
            // btnInvert
            // 
            this.btnInvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.btnInvert.FlatAppearance.BorderSize = 0;
            this.btnInvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvert.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvert.Location = new System.Drawing.Point(79, 0);
            this.btnInvert.Margin = new System.Windows.Forms.Padding(0);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(55, 31);
            this.btnInvert.TabIndex = 3;
            this.btnInvert.Text = "Invert";
            this.btnInvert.UseVisualStyleBackColor = false;
            // 
            // btnNoise
            // 
            this.btnNoise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.btnNoise.FlatAppearance.BorderSize = 0;
            this.btnNoise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoise.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoise.Location = new System.Drawing.Point(134, 0);
            this.btnNoise.Margin = new System.Windows.Forms.Padding(0);
            this.btnNoise.Name = "btnNoise";
            this.btnNoise.Size = new System.Drawing.Size(55, 31);
            this.btnNoise.TabIndex = 4;
            this.btnNoise.Text = "Noise";
            this.btnNoise.UseVisualStyleBackColor = false;
            // 
            // btnContrast
            // 
            this.btnContrast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.btnContrast.FlatAppearance.BorderSize = 0;
            this.btnContrast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContrast.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContrast.Location = new System.Drawing.Point(189, 0);
            this.btnContrast.Margin = new System.Windows.Forms.Padding(0);
            this.btnContrast.Name = "btnContrast";
            this.btnContrast.Size = new System.Drawing.Size(68, 31);
            this.btnContrast.TabIndex = 5;
            this.btnContrast.Text = "Contrast";
            this.btnContrast.UseVisualStyleBackColor = false;
            // 
            // btnRgb
            // 
            this.btnRgb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.btnRgb.FlatAppearance.BorderSize = 0;
            this.btnRgb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRgb.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRgb.Location = new System.Drawing.Point(257, 0);
            this.btnRgb.Margin = new System.Windows.Forms.Padding(0);
            this.btnRgb.Name = "btnRgb";
            this.btnRgb.Size = new System.Drawing.Size(43, 31);
            this.btnRgb.TabIndex = 6;
            this.btnRgb.Text = "RGB";
            this.btnRgb.UseVisualStyleBackColor = false;
            // 
            // btnFlip
            // 
            this.btnFlip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.btnFlip.FlatAppearance.BorderSize = 0;
            this.btnFlip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlip.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlip.Location = new System.Drawing.Point(300, 0);
            this.btnFlip.Margin = new System.Windows.Forms.Padding(0);
            this.btnFlip.Name = "btnFlip";
            this.btnFlip.Size = new System.Drawing.Size(43, 31);
            this.btnFlip.TabIndex = 7;
            this.btnFlip.Text = "Flip";
            this.btnFlip.UseVisualStyleBackColor = false;
            // 
            // btnPixel
            // 
            this.btnPixel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.btnPixel.FlatAppearance.BorderSize = 0;
            this.btnPixel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPixel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPixel.Location = new System.Drawing.Point(343, 0);
            this.btnPixel.Margin = new System.Windows.Forms.Padding(0);
            this.btnPixel.Name = "btnPixel";
            this.btnPixel.Size = new System.Drawing.Size(43, 31);
            this.btnPixel.TabIndex = 8;
            this.btnPixel.Text = "Pixel";
            this.btnPixel.UseVisualStyleBackColor = false;
            // 
            // btnSharpen
            // 
            this.btnSharpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.btnSharpen.FlatAppearance.BorderSize = 0;
            this.btnSharpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSharpen.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSharpen.Location = new System.Drawing.Point(386, 0);
            this.btnSharpen.Margin = new System.Windows.Forms.Padding(0);
            this.btnSharpen.Name = "btnSharpen";
            this.btnSharpen.Size = new System.Drawing.Size(64, 31);
            this.btnSharpen.TabIndex = 9;
            this.btnSharpen.Text = "Sharpen";
            this.btnSharpen.UseVisualStyleBackColor = false;
            this.btnSharpen.Click += new System.EventHandler(this.btnSharpen_Click);
            // 
            // btnBlur
            // 
            this.btnBlur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.btnBlur.FlatAppearance.BorderSize = 0;
            this.btnBlur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlur.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlur.Location = new System.Drawing.Point(450, 0);
            this.btnBlur.Margin = new System.Windows.Forms.Padding(0);
            this.btnBlur.Name = "btnBlur";
            this.btnBlur.Size = new System.Drawing.Size(43, 31);
            this.btnBlur.TabIndex = 10;
            this.btnBlur.Text = "Blur";
            this.btnBlur.UseVisualStyleBackColor = false;
            // 
            // btnEnhance
            // 
            this.btnEnhance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.btnEnhance.FlatAppearance.BorderSize = 0;
            this.btnEnhance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnhance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnhance.Location = new System.Drawing.Point(493, 0);
            this.btnEnhance.Margin = new System.Windows.Forms.Padding(0);
            this.btnEnhance.Name = "btnEnhance";
            this.btnEnhance.Size = new System.Drawing.Size(65, 31);
            this.btnEnhance.TabIndex = 11;
            this.btnEnhance.Text = "Enhance";
            this.btnEnhance.UseVisualStyleBackColor = false;
            // 
            // flowSideBar
            // 
            this.flowSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.flowSideBar.Controls.Add(this.txtOriginal);
            this.flowSideBar.Controls.Add(this.pictureBox1);
            this.flowSideBar.Controls.Add(this.txtHistogram);
            this.flowSideBar.Controls.Add(this.pictureBox2);
            this.flowSideBar.Controls.Add(this.txtFilterValue);
            this.flowSideBar.Controls.Add(this.tbFilterValue);
            this.flowSideBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowSideBar.Location = new System.Drawing.Point(675, 42);
            this.flowSideBar.Margin = new System.Windows.Forms.Padding(9, 9, 3, 3);
            this.flowSideBar.Name = "flowSideBar";
            this.flowSideBar.Size = new System.Drawing.Size(241, 493);
            this.flowSideBar.TabIndex = 3;
            this.flowSideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.flowSideBar_Paint);
            // 
            // txtOriginal
            // 
            this.txtOriginal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.txtOriginal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOriginal.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOriginal.Location = new System.Drawing.Point(10, 20);
            this.txtOriginal.Margin = new System.Windows.Forms.Padding(10, 20, 3, 3);
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.ReadOnly = true;
            this.txtOriginal.Size = new System.Drawing.Size(209, 16);
            this.txtOriginal.TabIndex = 0;
            this.txtOriginal.Text = "Original";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtHistogram
            // 
            this.txtHistogram.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHistogram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.txtHistogram.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHistogram.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistogram.Location = new System.Drawing.Point(10, 193);
            this.txtHistogram.Margin = new System.Windows.Forms.Padding(10, 20, 3, 3);
            this.txtHistogram.Name = "txtHistogram";
            this.txtHistogram.ReadOnly = true;
            this.txtHistogram.Size = new System.Drawing.Size(209, 16);
            this.txtHistogram.TabIndex = 2;
            this.txtHistogram.Text = "Histogram";
            this.txtHistogram.TextChanged += new System.EventHandler(this.txtHistogram_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 215);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(16, 3, 3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(205, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFilterValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilterValue.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterValue.Location = new System.Drawing.Point(10, 336);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(10, 20, 3, 3);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.ReadOnly = true;
            this.txtFilterValue.Size = new System.Drawing.Size(209, 16);
            this.txtFilterValue.TabIndex = 5;
            this.txtFilterValue.Text = "Filter Value";
            this.txtFilterValue.Visible = false;
            // 
            // tbFilterValue
            // 
            this.tbFilterValue.Location = new System.Drawing.Point(30, 358);
            this.tbFilterValue.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.tbFilterValue.Maximum = 100;
            this.tbFilterValue.Name = "tbFilterValue";
            this.tbFilterValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbFilterValue.Size = new System.Drawing.Size(172, 45);
            this.tbFilterValue.TabIndex = 4;
            this.tbFilterValue.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // pbMain
            // 
            this.pbMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbMain.Image = ((System.Drawing.Image)(resources.GetObject("pbMain.Image")));
            this.pbMain.Location = new System.Drawing.Point(0, 0);
            this.pbMain.Margin = new System.Windows.Forms.Padding(0);
            this.pbMain.MaximumSize = new System.Drawing.Size(750, 750);
            this.pbMain.MinimumSize = new System.Drawing.Size(250, 250);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(282, 282);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMain.TabIndex = 0;
            this.pbMain.TabStop = false;
            this.pbMain.Click += new System.EventHandler(this.pbMain_Click);
            // 
            // flowImageEdited
            // 
            this.flowImageEdited.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowImageEdited.AutoSize = true;
            this.flowImageEdited.Controls.Add(this.pbMain);
            this.flowImageEdited.Location = new System.Drawing.Point(196, 134);
            this.flowImageEdited.Name = "flowImageEdited";
            this.flowImageEdited.Size = new System.Drawing.Size(292, 292);
            this.flowImageEdited.TabIndex = 4;
            // 
            // formVsCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(916, 535);
            this.Controls.Add(this.flowImageEdited);
            this.Controls.Add(this.flowSideBar);
            this.Controls.Add(this.divNavbar);
            this.Name = "formVsCam";
            this.Text = "VS CAM";
            this.divNavbar.ResumeLayout(false);
            this.divNavbar.PerformLayout();
            this.flowFiltros.ResumeLayout(false);
            this.flowSideBar.ResumeLayout(false);
            this.flowSideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFilterValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.flowImageEdited.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel divNavbar;
        private System.Windows.Forms.FlowLayoutPanel flowInsideNavbarContent;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCamara;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnFilters;
        private System.Windows.Forms.FlowLayoutPanel flowContent;
        private System.Windows.Forms.FlowLayoutPanel flowSideBar;
        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtHistogram;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.FlowLayoutPanel flowImageEdited;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnBrightness;
        private System.Windows.Forms.Button btnInvert;
        private System.Windows.Forms.Button btnNoise;
        private System.Windows.Forms.Button btnContrast;
        private System.Windows.Forms.Button btnRgb;
        private System.Windows.Forms.Button btnFlip;
        private System.Windows.Forms.Button btnPixel;
        private System.Windows.Forms.Button btnSharpen;
        private System.Windows.Forms.Button btnBlur;
        private System.Windows.Forms.Button btnEnhance;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.TrackBar tbFilterValue;
        private System.Windows.Forms.FlowLayoutPanel flowFiltros;
    }
}