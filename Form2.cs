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
            txtFilterValue.Visible = true;
            /*btnBrightness.Visible = true;
            btnContrast.Visible = true;
            btnBlur.Visible = true;
            btnEnhance.Visible = true;
            btnFlip.Visible = true;
            btnInvert.Visible = true;
            btnNoise.Visible = true;
            btnPixel.Visible = true;
            btnRgb.Visible = true;
            btnSharpen.Visible = true;*/

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnBack.Visible = false;

            btnCamara.Visible = true;
            btnFilters.Visible = true;
            btnFile.Visible = true;

            flowFiltros.Visible = false;
            txtFilterValue.Visible = false;
            /*btnBrightness.Visible = false;
            btnContrast.Visible = false;
            btnBlur.Visible = false;
            btnEnhance.Visible = false;
            btnFlip.Visible = false;
            btnInvert.Visible = false;
            btnNoise.Visible = false;
            btnPixel.Visible = false;
            btnRgb.Visible = false;
            btnSharpen.Visible = false;*/
        }

        private void btnCamara_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void flowSideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSharpen_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void divNavbar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
