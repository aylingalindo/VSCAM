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
        public string filtroActivo = "";

        public float rg = 1.1f;
        public float gg = 1.1f;
        public float bg = 1.1f;

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

        public void ColorFilter(string color)
        {
            int x = 0;
            int y = 0;
            resultante = new Bitmap(original.Width, original.Height);
            Color rColor = new Color();
            Color oColor = new Color();

            int r = 0;
            int g = 0;
            int b = 0;

            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);

                    if(color == "r")
                        rColor = Color.FromArgb(oColor.R, 0, 0);
                    else if (color == "g")
                        rColor = Color.FromArgb(0, oColor.G, 0);
                    else if (color == "b")
                        rColor = Color.FromArgb(0, 0, oColor.B);

                    resultante.SetPixel(x, y, rColor);
                }
            }
            this.Invalidate();
            pbMain.Image = resultante;
        }

        public void BrightnessFilter(float pBrillo)
        {

            int x = 0;
            int y = 0;
            resultante = new Bitmap(original.Width, original.Height);
            Color rColor = new Color();
            Color oColor = new Color();

            int r = 0;
            int g = 0;
            int b = 0;

            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);

                    r = (int)(oColor.R * pBrillo);
                    g = (int)(oColor.G * pBrillo);
                    b = (int)(oColor.B * pBrillo);

                    if (r > 255)
                        r = 255;
                    else if (r < 0)
                        r = 0;

                    if (g > 255)
                        g = 255;
                    else if (g < 0)
                        g = 0;

                    if (b > 255)
                        b = 255;
                    else if (b < 0)
                        b = 0;

                    rColor = Color.FromArgb(r, g, b);
                    resultante.SetPixel(x, y, rColor);
                }
            }
            this.Invalidate();
            pbMain.Image = resultante;
        }

        public void NoiseFilter(int porcentaje)
        {
            int x = 0;
            int y = 0;

            int rangoMin = 85;
            int rangoMax = 115; // 170
            float pBrillo = 0;

            Random rnd = new Random();
            Color rColor;
            Color oColor;
            resultante = new Bitmap(original.Width, original.Height);
            int r = 0;
            int g = 0;
            int b = 0;

            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    if(rnd.Next(1,100) <= porcentaje)
                    {
                        pBrillo = rnd.Next(rangoMin, rangoMax) / 100.0f;
                        oColor = original.GetPixel(x, y);

                        r = (int)(oColor.R * pBrillo);
                        g = (int)(oColor.G * pBrillo);
                        b = (int)(oColor.B * pBrillo);

                        if (r > 255)
                            r = 255;
                        else if (r < 0)
                            r = 0;

                        if (g > 255)
                            g = 255;
                        else if (g < 0)
                            g = 0;

                        if (b > 255)
                            b = 255;
                        else if (b < 0)
                            b = 0;

                        rColor = Color.FromArgb(r, g, b);
                    }
                    else
                    {
                        rColor = original.GetPixel(x, y);
                    }
                    resultante.SetPixel(x, y, rColor);
                }
            }
            this.Invalidate();
            pbMain.Image = resultante;
        }

        public void ContrastFilter(int contraste)
        {
            float c = (100.0f + contraste) / 100.0f;
            c *= c;

            int x = 0;
            int y = 0;
            resultante = new Bitmap(original.Width, original.Height);
            Color rColor = new Color();
            Color oColor = new Color();

            float r = 0;
            float g = 0;
            float b = 0;

            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);

                    r = ((((oColor.R / 255.0f) - 0.5f) * c) + 0.5f) * 255;
                    if (r > 255)
                        r = 255;
                    else if (r < 0)
                        r = 0;

                    g = ((((oColor.G / 255.0f) - 0.5f) * c) + 0.5f) * 255;
                    if (g > 255)
                        g = 255;
                    else if (g < 0)
                        g = 0;

                    b = ((((oColor.B / 255.0f) - 0.5f) * c) + 0.5f) * 255;
                    if (b > 255)
                        b = 255;
                    else if (b < 0)
                        b = 0;

                    rColor = Color.FromArgb((int)r, (int)g, (int)b);
                    resultante.SetPixel(x, y, rColor);
                }
            }
            this.Invalidate();
            pbMain.Image = resultante;

        }

        public void PixelFilter(int pixels)
        {
            while (original.Width % pixels != 0 || original.Width % pixels != 0)
            {
                pixels--;
                if (pixels <= 0)
                {
                    while (original.Width % pixels != 0 || original.Width % pixels != 0)
                    {
                        pixels++;
                    }
                    break;
                }
            }

            int x = 0;
            int y = 0;
            int xm = 0;
            int ym = 0;

            Color rColor;
            Color oColor;

            int rs = 0;
            int gs = 0;
            int bs = 0;

            int r = 0;
            int g = 0;
            int b = 0;

            resultante = new Bitmap(original.Width, original.Height);

            for (x = 0; x < original.Width - pixels; x += pixels)
            {
                for (y = 0; y < original.Height - pixels; y += pixels)
                {
                    rs = 0;
                    gs = 0;
                    bs = 0;

                    for (xm = x; xm < (x+pixels); xm++)
                    {
                        for (ym = y; ym < (y+pixels); ym++)
                        {
                            oColor = original.GetPixel(x, y);
                            rs += oColor.R;
                            gs += oColor.G;
                            bs += oColor.B;
                        }
                    }

                    r = rs / (pixels * pixels);
                    g = gs / (pixels * pixels);
                    b = bs / (pixels * pixels);

                    rColor = Color.FromArgb(r,g,b);
                    for (xm = x; xm < (x + pixels); xm++)
                    {
                        for (ym = y; ym < (y + pixels); ym++)
                        {
                            resultante.SetPixel(xm, ym, rColor);
                        }
                    }
                }
            }
            this.Invalidate();
            pbMain.Image = resultante;

        }

        public void EnhanceFilter()
        {
            int x = 0;
            int y = 0;
            resultante = new Bitmap(original.Width, original.Height);
            Color rColor = new Color();
            Color oColor = new Color();

            float r = 0;
            float g = 0;
            float b = 0;
            int n = 0;

            int[] rGamma = new int[256];
            int[] gGamma = new int[256];
            int[] bGamma = new int[256];

            for (n = 0; n < 256; ++n)
            {
                rGamma[n] = Math.Min(255, (int)((255.0 * Math.Pow(n / 255.0f, 1.0f / rg)) + 0.5f));
                gGamma[n] = Math.Min(255, (int)((255.0 * Math.Pow(n / 255.0f, 1.0f / gg)) + 0.5f));
                bGamma[n] = Math.Min(255, (int)((255.0 * Math.Pow(n / 255.0f, 1.0f / bg)) + 0.5f));
            }


            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);

                    r = rGamma[oColor.R];
                    g = gGamma[oColor.G];
                    b = bGamma[oColor.B];

                    rColor = Color.FromArgb((int)r, (int)g, (int)b);
                    resultante.SetPixel(x, y, rColor);
                }
            }
            this.Invalidate();
            pbMain.Image = resultante;
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
            filtroActivo = "Sharpen";
            tbFilterValue.Visible = true;
            txtFilterValue.Visible = true;
        }

        private void btnBrightness_Click(object sender, EventArgs e)
        {
            filtroActivo = "Brightness";
            tbFilterValue.Visible = true;
            txtFilterValue.Visible = true;

            tbFilterValue.Minimum = 0;
            tbFilterValue.Maximum = 20;
            tbFilterValue.Value = 20;


            float pBrillo = 2.0f;

            BrightnessFilter(pBrillo);
        }

        private void tbFilterValue_Scroll(object sender, EventArgs e)
        {
            switch (filtroActivo)
            { 
                case "Brightness":
                    float pBrillo = tbFilterValue.Value;
                    BrightnessFilter(pBrillo / 10);
                    break;
                case "Noise":
                    NoiseFilter(tbFilterValue.Value);
                    break;
                case "Contrast":
                    ContrastFilter(tbFilterValue.Value);
                    break;
                case "Pixel":
                    PixelFilter(tbFilterValue.Value);
                    break;
                case "Enhance":
                    rg = tbFilterValue.Value / 10;
                    EnhanceFilter();
                    break;
                default:
                    break;
            }
    
        }

        private void btnNoise_Click(object sender, EventArgs e)
        {
            filtroActivo = "Noise";
            tbFilterValue.Visible = true;
            txtFilterValue.Visible = true;
            panelRGB.Visible = false;

            tbFilterValue.Minimum = 0;
            tbFilterValue.Maximum = 20;
            tbFilterValue.Value = 20;

            NoiseFilter(20);

        }

        private void btnContrast_Click(object sender, EventArgs e)
        {
            filtroActivo = "Contrast";
            tbFilterValue.Visible = true;
            txtFilterValue.Visible = true;
            panelRGB.Visible = false;

            tbFilterValue.Minimum = -50;
            tbFilterValue.Maximum = 50;
            tbFilterValue.Value = 50;

            ContrastFilter(50);
        }

        private void btnPixel_Click(object sender, EventArgs e)
        {
            filtroActivo = "Pixel";
            tbFilterValue.Visible = true;
            txtFilterValue.Visible = true;
            panelRGB.Visible = false;

            tbFilterValue.Minimum = 2;
            tbFilterValue.Maximum = 100;
            tbFilterValue.Value = 100;

            PixelFilter(100);
        }

        private void btnBlur_Click(object sender, EventArgs e)
        {
            filtroActivo = "Blur";
            tbFilterValue.Visible = true;
            txtFilterValue.Visible = true;
            panelRGB.Visible = false;
        }

        private void btnEnhance_Click(object sender, EventArgs e)
        {
            filtroActivo = "Enhance";
            tbFilterValue.Visible = true;
            tbGamma1.Visible = true;
            tbGamma2.Visible = true;
            txtFilterValue.Visible = true;
            panelRGB.Visible = false;

            rg = 1.1f;
            gg = 1.1f;
            bg = 1.1f;

            tbFilterValue.Minimum = 0;
            tbFilterValue.Maximum = 20;
            tbFilterValue.Value = 11;

            tbGamma1.Minimum = 0;
            tbGamma1.Maximum = 20;
            tbGamma1.Value = 11;

            tbGamma2.Minimum = 0;
            tbGamma2.Maximum = 20;
            tbGamma2.Value = 11;

            EnhanceFilter();
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            filtroActivo = "Invert";
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
            filtroActivo = "Flip";
            tbFilterValue.Visible = false;
            txtFilterValue.Visible = false;
            panelRGB.Visible = false;

            int x = 0;
            int y = 0;
            resultante = new Bitmap(original.Width, original.Height);
            Color rColor = new Color();
            Color oColor = new Color();

            for(x = 0; x < original.Width; x++)
            {
                for(y = 0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);

                    rColor = Color.FromArgb(oColor.R, oColor.G, oColor.B);

                    resultante.SetPixel(original.Width - x - 1, y, rColor);

                }
            }

            this.Invalidate();

            pbMain.Image = resultante;
        }

        private void btnRgb_Click(object sender, EventArgs e)
        {
            filtroActivo = "Rgb";
            tbFilterValue.Visible = false;
            txtFilterValue.Visible = true;

            // rgb buttons
            panelRGB.Visible = true;

            ColorFilter("r");
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

        private void btnRgbRed_Click(object sender, EventArgs e)
        {
            ColorFilter("r");
        }

        private void btnRgbGreen_Click(object sender, EventArgs e)
        {
            ColorFilter("g");
        }

        private void btnRgbBlue_Click(object sender, EventArgs e)
        {
            ColorFilter("b");
        }

        private void tbGamma2_Scroll(object sender, EventArgs e)
        {
            gg = tbGamma2.Value / 10;
            EnhanceFilter();
        }

        private void tbGamma1_Scroll(object sender, EventArgs e)
        {
            bg = tbGamma1.Value / 10;
            EnhanceFilter();
        }
    }
}
