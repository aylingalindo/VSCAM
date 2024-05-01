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
            this.btnExport = new System.Windows.Forms.Button();
            this.flowSideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.pbOriginal = new System.Windows.Forms.PictureBox();
            this.txtHistogram = new System.Windows.Forms.TextBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.tbFilterValue = new System.Windows.Forms.TrackBar();
            this.panelRGB = new System.Windows.Forms.Panel();
            this.btnRgbRed = new System.Windows.Forms.Button();
            this.btnRgbGreen = new System.Windows.Forms.Button();
            this.btnRgbBlue = new System.Windows.Forms.Button();
            this.tbGamma2 = new System.Windows.Forms.TrackBar();
            this.tbGamma1 = new System.Windows.Forms.TrackBar();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.flowImageEdited = new System.Windows.Forms.FlowLayoutPanel();
            this.panelCamara = new System.Windows.Forms.Panel();
            this.btnStartCamera = new System.Windows.Forms.Button();
            this.cbDevices = new System.Windows.Forms.ComboBox();
            this.pbCamera = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowHistogram = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.divNavbar.SuspendLayout();
            this.flowFiltros.SuspendLayout();
            this.flowSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFilterValue)).BeginInit();
            this.panelRGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGamma2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGamma1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.flowImageEdited.SuspendLayout();
            this.panelCamara.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
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
            this.divNavbar.Controls.Add(this.btnExport);
            this.divNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.divNavbar.Location = new System.Drawing.Point(0, 0);
            this.divNavbar.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.divNavbar.Name = "divNavbar";
            this.divNavbar.Size = new System.Drawing.Size(916, 42);
            this.divNavbar.TabIndex = 1;
            this.divNavbar.WrapContents = false;
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
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
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
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
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
            this.flowFiltros.Size = new System.Drawing.Size(563, 34);
            this.flowFiltros.TabIndex = 5;
            this.flowFiltros.Visible = false;
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
            this.btnBrightness.Click += new System.EventHandler(this.btnBrightness_Click);
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
            this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click);
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
            this.btnNoise.Click += new System.EventHandler(this.btnNoise_Click);
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
            this.btnContrast.Click += new System.EventHandler(this.btnContrast_Click);
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
            this.btnRgb.Click += new System.EventHandler(this.btnRgb_Click);
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
            this.btnFlip.Click += new System.EventHandler(this.btnFlip_Click);
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
            this.btnPixel.Click += new System.EventHandler(this.btnPixel_Click);
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
            this.btnBlur.Click += new System.EventHandler(this.btnBlur_Click);
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
            this.btnEnhance.Click += new System.EventHandler(this.btnEnhance_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(807, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(57, 31);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Visible = false;
            // 
            // flowSideBar
            // 
            this.flowSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.flowSideBar.Controls.Add(this.flowLayoutPanel1);
            this.flowSideBar.Controls.Add(this.flowLayoutPanel2);
            this.flowSideBar.Controls.Add(this.flowHistogram);
            this.flowSideBar.Controls.Add(this.txtFilterValue);
            this.flowSideBar.Controls.Add(this.tbFilterValue);
            this.flowSideBar.Controls.Add(this.panelRGB);
            this.flowSideBar.Controls.Add(this.tbGamma2);
            this.flowSideBar.Controls.Add(this.tbGamma1);
            this.flowSideBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowSideBar.Location = new System.Drawing.Point(648, 42);
            this.flowSideBar.Margin = new System.Windows.Forms.Padding(9, 9, 3, 3);
            this.flowSideBar.Name = "flowSideBar";
            this.flowSideBar.Size = new System.Drawing.Size(268, 493);
            this.flowSideBar.TabIndex = 3;
            // 
            // txtOriginal
            // 
            this.txtOriginal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.txtOriginal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOriginal.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOriginal.Location = new System.Drawing.Point(10, 10);
            this.txtOriginal.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.ReadOnly = true;
            this.txtOriginal.Size = new System.Drawing.Size(209, 16);
            this.txtOriginal.TabIndex = 0;
            this.txtOriginal.Text = "Original";
            // 
            // pbOriginal
            // 
            this.pbOriginal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbOriginal.Image = ((System.Drawing.Image)(resources.GetObject("pbOriginal.Image")));
            this.pbOriginal.Location = new System.Drawing.Point(5, 34);
            this.pbOriginal.Margin = new System.Windows.Forms.Padding(5);
            this.pbOriginal.MaximumSize = new System.Drawing.Size(500, 500);
            this.pbOriginal.Name = "pbOriginal";
            this.pbOriginal.Size = new System.Drawing.Size(260, 109);
            this.pbOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOriginal.TabIndex = 1;
            this.pbOriginal.TabStop = false;
            // 
            // txtHistogram
            // 
            this.txtHistogram.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHistogram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.txtHistogram.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHistogram.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistogram.Location = new System.Drawing.Point(10, 20);
            this.txtHistogram.Margin = new System.Windows.Forms.Padding(10, 20, 3, 3);
            this.txtHistogram.Name = "txtHistogram";
            this.txtHistogram.ReadOnly = true;
            this.txtHistogram.Size = new System.Drawing.Size(209, 16);
            this.txtHistogram.TabIndex = 2;
            this.txtHistogram.Text = "Histogram";
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFilterValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilterValue.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterValue.Location = new System.Drawing.Point(10, 342);
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
            this.tbFilterValue.Location = new System.Drawing.Point(30, 364);
            this.tbFilterValue.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.tbFilterValue.Maximum = 100;
            this.tbFilterValue.Name = "tbFilterValue";
            this.tbFilterValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbFilterValue.Size = new System.Drawing.Size(205, 45);
            this.tbFilterValue.TabIndex = 4;
            this.tbFilterValue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbFilterValue.Visible = false;
            this.tbFilterValue.Scroll += new System.EventHandler(this.tbFilterValue_Scroll);
            // 
            // panelRGB
            // 
            this.panelRGB.Controls.Add(this.btnRgbRed);
            this.panelRGB.Controls.Add(this.btnRgbGreen);
            this.panelRGB.Controls.Add(this.btnRgbBlue);
            this.panelRGB.Location = new System.Drawing.Point(30, 415);
            this.panelRGB.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.panelRGB.Name = "panelRGB";
            this.panelRGB.Size = new System.Drawing.Size(202, 27);
            this.panelRGB.TabIndex = 9;
            this.panelRGB.Visible = false;
            // 
            // btnRgbRed
            // 
            this.btnRgbRed.BackColor = System.Drawing.Color.White;
            this.btnRgbRed.FlatAppearance.BorderSize = 0;
            this.btnRgbRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRgbRed.Location = new System.Drawing.Point(7, 0);
            this.btnRgbRed.Margin = new System.Windows.Forms.Padding(30, 3, 9, 3);
            this.btnRgbRed.Name = "btnRgbRed";
            this.btnRgbRed.Size = new System.Drawing.Size(49, 23);
            this.btnRgbRed.TabIndex = 6;
            this.btnRgbRed.Text = "Red";
            this.btnRgbRed.UseVisualStyleBackColor = false;
            this.btnRgbRed.Click += new System.EventHandler(this.btnRgbRed_Click);
            // 
            // btnRgbGreen
            // 
            this.btnRgbGreen.BackColor = System.Drawing.Color.White;
            this.btnRgbGreen.FlatAppearance.BorderSize = 0;
            this.btnRgbGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRgbGreen.Location = new System.Drawing.Point(74, 1);
            this.btnRgbGreen.Margin = new System.Windows.Forms.Padding(9, 3, 9, 3);
            this.btnRgbGreen.Name = "btnRgbGreen";
            this.btnRgbGreen.Size = new System.Drawing.Size(49, 23);
            this.btnRgbGreen.TabIndex = 7;
            this.btnRgbGreen.Text = "Green";
            this.btnRgbGreen.UseVisualStyleBackColor = false;
            this.btnRgbGreen.Click += new System.EventHandler(this.btnRgbGreen_Click);
            // 
            // btnRgbBlue
            // 
            this.btnRgbBlue.BackColor = System.Drawing.Color.White;
            this.btnRgbBlue.FlatAppearance.BorderSize = 0;
            this.btnRgbBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRgbBlue.Location = new System.Drawing.Point(141, 1);
            this.btnRgbBlue.Margin = new System.Windows.Forms.Padding(9, 3, 9, 3);
            this.btnRgbBlue.Name = "btnRgbBlue";
            this.btnRgbBlue.Size = new System.Drawing.Size(49, 23);
            this.btnRgbBlue.TabIndex = 8;
            this.btnRgbBlue.Text = "Blue";
            this.btnRgbBlue.UseVisualStyleBackColor = false;
            this.btnRgbBlue.Click += new System.EventHandler(this.btnRgbBlue_Click);
            // 
            // tbGamma2
            // 
            this.tbGamma2.Location = new System.Drawing.Point(30, 448);
            this.tbGamma2.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.tbGamma2.Maximum = 100;
            this.tbGamma2.Name = "tbGamma2";
            this.tbGamma2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbGamma2.Size = new System.Drawing.Size(205, 45);
            this.tbGamma2.TabIndex = 10;
            this.tbGamma2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbGamma2.Visible = false;
            this.tbGamma2.Scroll += new System.EventHandler(this.tbGamma2_Scroll);
            // 
            // tbGamma1
            // 
            this.tbGamma1.Location = new System.Drawing.Point(30, 499);
            this.tbGamma1.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.tbGamma1.Maximum = 100;
            this.tbGamma1.Name = "tbGamma1";
            this.tbGamma1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbGamma1.Size = new System.Drawing.Size(205, 45);
            this.tbGamma1.TabIndex = 11;
            this.tbGamma1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbGamma1.Visible = false;
            this.tbGamma1.Scroll += new System.EventHandler(this.tbGamma1_Scroll);
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
            this.pbMain.Size = new System.Drawing.Size(428, 364);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMain.TabIndex = 0;
            this.pbMain.TabStop = false;
            // 
            // flowImageEdited
            // 
            this.flowImageEdited.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowImageEdited.AutoSize = true;
            this.flowImageEdited.Controls.Add(this.pbMain);
            this.flowImageEdited.Location = new System.Drawing.Point(130, 98);
            this.flowImageEdited.Name = "flowImageEdited";
            this.flowImageEdited.Size = new System.Drawing.Size(428, 381);
            this.flowImageEdited.TabIndex = 4;
            // 
            // panelCamara
            // 
            this.panelCamara.AutoSize = true;
            this.panelCamara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.panelCamara.Controls.Add(this.btnStartCamera);
            this.panelCamara.Controls.Add(this.cbDevices);
            this.panelCamara.Controls.Add(this.pbCamera);
            this.panelCamara.Location = new System.Drawing.Point(0, 42);
            this.panelCamara.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelCamara.Name = "panelCamara";
            this.panelCamara.Size = new System.Drawing.Size(916, 499);
            this.panelCamara.TabIndex = 5;
            this.panelCamara.Visible = false;
            // 
            // btnStartCamera
            // 
            this.btnStartCamera.Location = new System.Drawing.Point(329, 454);
            this.btnStartCamera.Name = "btnStartCamera";
            this.btnStartCamera.Size = new System.Drawing.Size(75, 23);
            this.btnStartCamera.TabIndex = 2;
            this.btnStartCamera.Text = "Start";
            this.btnStartCamera.UseVisualStyleBackColor = true;
            this.btnStartCamera.Click += new System.EventHandler(this.btnStartCamera_Click);
            // 
            // cbDevices
            // 
            this.cbDevices.FormattingEnabled = true;
            this.cbDevices.Location = new System.Drawing.Point(45, 456);
            this.cbDevices.Name = "cbDevices";
            this.cbDevices.Size = new System.Drawing.Size(265, 21);
            this.cbDevices.TabIndex = 1;
            // 
            // pbCamera
            // 
            this.pbCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.pbCamera.Image = ((System.Drawing.Image)(resources.GetObject("pbCamera.Image")));
            this.pbCamera.Location = new System.Drawing.Point(46, 26);
            this.pbCamera.Name = "pbCamera";
            this.pbCamera.Size = new System.Drawing.Size(818, 413);
            this.pbCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCamera.TabIndex = 0;
            this.pbCamera.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.txtOriginal);
            this.flowLayoutPanel1.Controls.Add(this.pbOriginal);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(265, 144);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // flowHistogram
            // 
            this.flowHistogram.Location = new System.Drawing.Point(3, 200);
            this.flowHistogram.Name = "flowHistogram";
            this.flowHistogram.Size = new System.Drawing.Size(265, 119);
            this.flowHistogram.TabIndex = 13;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.txtHistogram);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 153);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(265, 41);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // formVsCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(916, 535);
            this.Controls.Add(this.panelCamara);
            this.Controls.Add(this.flowImageEdited);
            this.Controls.Add(this.flowSideBar);
            this.Controls.Add(this.divNavbar);
            this.Name = "formVsCam";
            this.Text = "VS CAM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formVsCam_FormClosed);
            this.Load += new System.EventHandler(this.formVsCam_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.formVsCam_Paint);
            this.divNavbar.ResumeLayout(false);
            this.divNavbar.PerformLayout();
            this.flowFiltros.ResumeLayout(false);
            this.flowSideBar.ResumeLayout(false);
            this.flowSideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFilterValue)).EndInit();
            this.panelRGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbGamma2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGamma1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.flowImageEdited.ResumeLayout(false);
            this.panelCamara.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
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
        private System.Windows.Forms.PictureBox pbOriginal;
        private System.Windows.Forms.TextBox txtHistogram;
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
        private System.Windows.Forms.Button btnRgbRed;
        private System.Windows.Forms.Button btnRgbGreen;
        private System.Windows.Forms.Button btnRgbBlue;
        private System.Windows.Forms.Panel panelRGB;
        private System.Windows.Forms.Panel panelCamara;
        private System.Windows.Forms.PictureBox pbCamera;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ComboBox cbDevices;
        private System.Windows.Forms.Button btnStartCamera;
        private System.Windows.Forms.TrackBar tbGamma2;
        private System.Windows.Forms.TrackBar tbGamma1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowHistogram;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}