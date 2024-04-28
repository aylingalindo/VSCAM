using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Video.DirectShow;
using AForge.Video;
using System.Windows.Forms;

namespace vscam
{
    public partial class formVsCam : Form
    {
        private bool devicesExist;
        private FilterInfoCollection myDevices;
        private VideoCaptureDevice myWebCam;
        public Bitmap resultante;
        public Bitmap original;
        private Home form1 = new Home();

        public formVsCam(Bitmap imagen)
        {
            InitializeComponent();
            UpdateImage(imagen);


        }
        public void UpdateImage(Bitmap imagen)
        {
            if (imagen != null)
            {
                original = new Bitmap(imagen);
                pbMain.Image = new Bitmap(imagen);
                pbOriginal.Image = new Bitmap(imagen);
            }
        }

        public void DeviceLoad()
        {
            myDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if(myDevices.Count > 0)
            {
                devicesExist = true;

                for (int i = 0; i < myDevices.Count; i++)
                {
                    cbDevices.Items.Add( myDevices[i].Name.ToString() );
                }
                cbDevices.Text = myDevices[0].Name.ToString();

            }else
            {
                devicesExist = false;
            }


        }

        public void CloseWebCam()
        {
            if (myWebCam != null && myWebCam.IsRunning)
            {
                myWebCam.SignalToStop();
                myWebCam = null;
            }

        }

        private void formVsCam_Load(object sender, EventArgs e)
        {
            DeviceLoad();
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

            int x = 0;
            int y = 0;
            resultante = new Bitmap(original.Width, original.Height);
            Color rColor = new Color();
            Color oColor = new Color();

            for(x=0; x < original.Width; x++)
            {
                for(y=0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);

                    rColor = Color.FromArgb(255 - oColor.R, 255 - oColor.G, 255 - oColor.B);

                    resultante.SetPixel(x, y, rColor);
                }
            }

            this.Invalidate();

            pbMain.Image = resultante;
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

        private void Capturing(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Image = (Bitmap)eventArgs.Frame.Clone();
            pbCamera.Image = Image;
        }

        private void btnStartCamera_Click(object sender, EventArgs e)
        {
            CloseWebCam();

            int i = cbDevices.SelectedIndex;
            string deviceName = myDevices[i].MonikerString;
            myWebCam = new VideoCaptureDevice(deviceName);
            myWebCam.NewFrame += new NewFrameEventHandler(Capturing);
            myWebCam.Start();
        }

        private void formVsCam_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseWebCam();
            Application.Exit();
        }

        private void formVsCam_Paint(object sender, PaintEventArgs e)
        {
            if(resultante != null)
            {
                Graphics g = e.Graphics;

                //AutoScrollMinSize = new Size(anchoVentana, altoVentana);
                //
                //g.DrawImage(resultante, new Rectangle(this.AutoScrollPosition.X, this.AutoScrollPosition.Y + 30, anchoVentana, altoVentana)
                //    );
                //
                //g.Dispose();
            }
        }
    }
}
