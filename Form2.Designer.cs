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
            this.flowInsideNavbarMain = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCamara = new System.Windows.Forms.Button();
            this.flowInsideNavbarContent = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFile = new System.Windows.Forms.Button();
            this.btnFilters = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtHistogram = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.divNavbar.SuspendLayout();
            this.flowInsideNavbarMain.SuspendLayout();
            this.flowInsideNavbarContent.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // divNavbar
            // 
            this.divNavbar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.divNavbar.BackColor = System.Drawing.Color.Transparent;
            this.divNavbar.Controls.Add(this.flowInsideNavbarMain);
            this.divNavbar.Controls.Add(this.flowInsideNavbarContent);
            this.divNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.divNavbar.Location = new System.Drawing.Point(0, 0);
            this.divNavbar.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.divNavbar.Name = "divNavbar";
            this.divNavbar.Size = new System.Drawing.Size(722, 34);
            this.divNavbar.TabIndex = 1;
            // 
            // flowInsideNavbarMain
            // 
            this.flowInsideNavbarMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.flowInsideNavbarMain.Controls.Add(this.btnHome);
            this.flowInsideNavbarMain.Controls.Add(this.btnCamara);
            this.flowInsideNavbarMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowInsideNavbarMain.Location = new System.Drawing.Point(3, 3);
            this.flowInsideNavbarMain.Name = "flowInsideNavbarMain";
            this.flowInsideNavbarMain.Size = new System.Drawing.Size(83, 31);
            this.flowInsideNavbarMain.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.Transparent;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(41, 31);
            this.btnHome.TabIndex = 0;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // btnCamara
            // 
            this.btnCamara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCamara.BackColor = System.Drawing.Color.Transparent;
            this.btnCamara.FlatAppearance.BorderSize = 0;
            this.btnCamara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCamara.ForeColor = System.Drawing.Color.Transparent;
            this.btnCamara.Image = ((System.Drawing.Image)(resources.GetObject("btnCamara.Image")));
            this.btnCamara.Location = new System.Drawing.Point(41, 0);
            this.btnCamara.Margin = new System.Windows.Forms.Padding(0);
            this.btnCamara.Name = "btnCamara";
            this.btnCamara.Size = new System.Drawing.Size(42, 31);
            this.btnCamara.TabIndex = 1;
            this.btnCamara.UseVisualStyleBackColor = false;
            // 
            // flowInsideNavbarContent
            // 
            this.flowInsideNavbarContent.AutoSize = true;
            this.flowInsideNavbarContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowInsideNavbarContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.flowInsideNavbarContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowInsideNavbarContent.Controls.Add(this.btnFile);
            this.flowInsideNavbarContent.Controls.Add(this.btnFilters);
            this.flowInsideNavbarContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.divNavbar.SetFlowBreak(this.flowInsideNavbarContent, true);
            this.flowInsideNavbarContent.Location = new System.Drawing.Point(92, 3);
            this.flowInsideNavbarContent.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.flowInsideNavbarContent.Name = "flowInsideNavbarContent";
            this.flowInsideNavbarContent.Size = new System.Drawing.Size(107, 33);
            this.flowInsideNavbarContent.TabIndex = 1;
            this.flowInsideNavbarContent.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel3_Paint);
            // 
            // btnFile
            // 
            this.btnFile.FlatAppearance.BorderSize = 0;
            this.btnFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFile.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFile.Location = new System.Drawing.Point(0, 0);
            this.btnFile.Margin = new System.Windows.Forms.Padding(0);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(50, 31);
            this.btnFile.TabIndex = 0;
            this.btnFile.Text = "File";
            this.btnFile.UseVisualStyleBackColor = true;
            // 
            // btnFilters
            // 
            this.btnFilters.FlatAppearance.BorderSize = 0;
            this.btnFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilters.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilters.Location = new System.Drawing.Point(50, 0);
            this.btnFilters.Margin = new System.Windows.Forms.Padding(0);
            this.btnFilters.Name = "btnFilters";
            this.btnFilters.Size = new System.Drawing.Size(55, 31);
            this.btnFilters.TabIndex = 1;
            this.btnFilters.Text = "Filters";
            this.btnFilters.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.pbMain);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 34);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(722, 474);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.flowLayoutPanel2.Controls.Add(this.txtOriginal);
            this.flowLayoutPanel2.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel2.Controls.Add(this.txtHistogram);
            this.flowLayoutPanel2.Controls.Add(this.pictureBox2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(481, 34);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(9, 9, 3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(241, 474);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // pbMain
            // 
            this.pbMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbMain.Image = ((System.Drawing.Image)(resources.GetObject("pbMain.Image")));
            this.pbMain.Location = new System.Drawing.Point(0, 0);
            this.pbMain.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.pbMain.MinimumSize = new System.Drawing.Size(250, 250);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(306, 281);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMain.TabIndex = 0;
            this.pbMain.TabStop = false;
            this.pbMain.Click += new System.EventHandler(this.pbMain_Click);
            // 
            // txtOriginal
            // 
            this.txtOriginal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.txtOriginal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOriginal.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOriginal.Location = new System.Drawing.Point(10, 10);
            this.txtOriginal.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.Size = new System.Drawing.Size(209, 16);
            this.txtOriginal.TabIndex = 0;
            this.txtOriginal.Text = "Original";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 32);
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
            this.txtHistogram.Location = new System.Drawing.Point(10, 173);
            this.txtHistogram.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.txtHistogram.Name = "txtHistogram";
            this.txtHistogram.Size = new System.Drawing.Size(209, 16);
            this.txtHistogram.TabIndex = 2;
            this.txtHistogram.Text = "Histogram";
            this.txtHistogram.TextChanged += new System.EventHandler(this.txtHistogram_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 195);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(205, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // formVsCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(722, 508);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.divNavbar);
            this.Name = "formVsCam";
            this.Text = "VS CAM";
            this.divNavbar.ResumeLayout(false);
            this.divNavbar.PerformLayout();
            this.flowInsideNavbarMain.ResumeLayout(false);
            this.flowInsideNavbarContent.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel divNavbar;
        private System.Windows.Forms.FlowLayoutPanel flowInsideNavbarMain;
        private System.Windows.Forms.FlowLayoutPanel flowInsideNavbarContent;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCamara;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnFilters;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtHistogram;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}