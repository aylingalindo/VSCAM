using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vscam
{
    public partial class formVsCam : Form
    {
        public formVsCam()
        {
            InitializeComponent();
        }

        private void pbMain_Click(object sender, EventArgs e)
        {

        }

        private void txtHistogram_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFilters_Click(object sender, EventArgs e)
        {
            btnFilters.Visible = false;
            btnCamara.Visible = false;
            btnFile.Visible = false;

            btnBack.Visible = true;

            flowFiltros.Visible = true;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnBack.Visible = false;

            btnCamara.Visible = true;
            btnFilters.Visible = true;
            btnFile.Visible = true;

            flowFiltros.Visible = false;
            txtFilterValue.Visible = false;
            tbFilterValue.Visible = false;
            panelRGB.Visible = false;
            btnExport.Visible = false;
            panelCamara.Visible = false;
        }

        private void btnSharpen_Click(object sender, EventArgs e)
        {
            tbFilterValue.Visible = true;
            txtFilterValue.Visible = true;
        }

        private void btnBrightness_Click(object sender, EventArgs e)
        {
            tbFilterValue.Visible = true;
            txtFilterValue.Visible = true;

        }

        private void tbFilterValue_Scroll(object sender, EventArgs e)
        {

        }

        private void btnNoise_Click(object sender, EventArgs e)
        {
            tbFilterValue.Visible = true;
            txtFilterValue.Visible = true;
            panelRGB.Visible = false;

        }

        private void btnContrast_Click(object sender, EventArgs e)
        {
            tbFilterValue.Visible = true;
            txtFilterValue.Visible = true;
            panelRGB.Visible = false;
        }

        private void btnPixel_Click(object sender, EventArgs e)
        {
            tbFilterValue.Visible = true;
            txtFilterValue.Visible = true;
            panelRGB.Visible = false;
        }

        private void btnBlur_Click(object sender, EventArgs e)
        {
            tbFilterValue.Visible = true;
            txtFilterValue.Visible = true;
            panelRGB.Visible = false;
        }

        private void btnEnhance_Click(object sender, EventArgs e)
        {
            tbFilterValue.Visible = true;
            txtFilterValue.Visible = true;
            panelRGB.Visible = false;
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            tbFilterValue.Visible = false;
            txtFilterValue.Visible = false;
            panelRGB.Visible = false;
        }

        private void btnFlip_Click(object sender, EventArgs e)
        {
            tbFilterValue.Visible = false;
            txtFilterValue.Visible = false;
            panelRGB.Visible = false;
        }

        private void btnRgb_Click(object sender, EventArgs e)
        {
            tbFilterValue.Visible = false;
            txtFilterValue.Visible = true;

            // rgb buttons
            panelRGB.Visible = true;
        }

        private void formVsCam_Load(object sender, EventArgs e)
        {

        }

        private void btnCamara_Click(object sender, EventArgs e)
        {
            flowImageEdited.Visible = false;
            flowSideBar.Visible = false;
            panelCamara.Visible = true;

            btnFilters.Visible = false;
            btnCamara.Visible = false;
            btnFile.Visible = false;
            btnBack.Visible = true;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            btnFilters.Visible = false;
            btnCamara.Visible = false;
            btnFile.Visible = false;

            btnExport.Visible = true;
            btnBack.Visible = true;

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home form1 = new Home();
            form1.Show();
            this.Hide();
        }
    }
}
