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
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

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
        private int[] histogramaR = new int[256];
        private int[] histogramaG = new int[256];
        private int[] histogramaB = new int[256];
        private int[,] conv3x3 = new int[3, 3];

        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");

        public float rg = 1.1f;
        public float gg = 1.1f;
        public float bg = 1.1f;

        public bool pause = false;

        public formVsCam(Bitmap imagen, VideoCapture capture)
        {
            InitializeComponent();

            if (imagen != null)
            {
                UpdateImage(imagen);
            }else if(capture != null)
            {
                UpdateVideo(capture);
            }

        }
        public void UpdateImage(Bitmap imagen)
        {
            original = new Bitmap(imagen);
            pbMain.Image = new Bitmap(imagen);
            pbOriginal.Image = new Bitmap(imagen);
            resultante = new Bitmap(original);

            ActualizarHistograma();
        }

        public async void UpdateVideo(VideoCapture capture)
        {
            while (!pause)
            {
                Mat m = new Mat();
                capture.Read(m);

                if (!m.IsEmpty)
                {
                    Bitmap frame = m.Bitmap;

                    Bitmap filteredFrame = await Task.Run(() => ApplySelectedFilter(frame));

                    pbMain.Image = filteredFrame;
                    pbOriginal.Image = m.Bitmap;

                    double fps = capture.GetCaptureProperty(CapProp.Fps);
                    await Task.Delay((int)(1000 / fps));
                    //Descomentar al final para mostrar funcionalidad
                    //UpdateHistogram(frame);
                    //UpdateHistogram2(filteredFrame);
                }
                else
                {
                    capture.SetCaptureProperty(CapProp.PosFrames, 0);
                }
            }
        }

        public void ActualizarHistograma() {

            int x = 0;
            int y = 0;
            Color rColor = new Color();

            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    rColor = resultante.GetPixel(x, y);
                    histogramaR[rColor.R]++;
                    histogramaG[rColor.G]++;
                    histogramaB[rColor.B]++;
                }
            }

            Histogram h = new Histogram(histogramaR, histogramaG, histogramaB);
            h.TopLevel = false;
            h.Location = new Point(30, 190);
            flowHistogram.Controls.Add(h);
            h.BringToFront();
            h.Show();
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

        public void SharpenFilter()
        {
            int x = 0;
            int y = 0;
            int[,,] buffer = new int[3,original.Height,original.Width];
            resultante = new Bitmap(original.Width, original.Height);
            Color rColor = new Color();
            Color oColor = new Color();

            int r = 0;
            int g = 0;
            int b = 0;

            // read pixels
            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);

                    buffer[0, y, x] = oColor.R;
                    buffer[1, y, x] = oColor.G;
                    buffer[2, y, x] = oColor.B;
                }
            }

            // sharpen image
            for (x = 1; x < original.Width -2; x++)
            {
                for (y = 1; y < original.Height -2; y++)
                {

                    r = (int)(buffer[0, y, x] + 0.5 * (buffer[0, y, x] - buffer[0, y - 1, x - 1]));
                    g = (int)(buffer[1, y, x] + 0.5 * (buffer[1, y, x] - buffer[1, y - 1, x - 1]));
                    b = (int)(buffer[2, y, x] + 0.5 * (buffer[2, y, x] - buffer[2, y - 1, x - 1]));

                    if (r > 255)
                        r = 255;
                    if (r < 0)
                        r = 0;
                    if (g > 255)
                        g = 255;
                    if (g < 0)
                        g = 0;
                    if (b > 255)
                        b = 255;
                    if (b < 0)
                        b = 0;


                    rColor = Color.FromArgb(r, g, b);
                    resultante.SetPixel(x, y, rColor);
                }
            }
            this.Invalidate();
            pbMain.Image = resultante;
        }

        public void GaussianBlurFilter(int radius)
        {
            resultante = new Bitmap(original.Width, original.Height);

            double deviation = radius / 3.0;

            // Create 1D Gaussian kernels for rows and columns
            double[] kernelX = CreateGaussianKernel(radius, deviation);
            double[] kernelY = CreateGaussianKernel(radius, deviation);

            // Apply separable convolution along rows
            ApplyConvolution(original, resultante, kernelX, radius, true);

            // Apply separable convolution along columns
            ApplyConvolution(resultante, resultante, kernelY, radius, false);

            this.Invalidate();
            pbMain.Image = resultante;
        }

        private static void ApplyConvolution(Bitmap source, Bitmap destination, double[] kernel, int radius, bool horizontal)
        {
            int size = 2 * radius + 1;
            int offset = radius;

            for (int y = 0; y < source.Height; y++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    double r = 0, g = 0, b = 0;

                    for (int i = 0; i < size; i++)
                    {
                        int index = horizontal ? x - offset + i : y - offset + i;
                        index = Math.Max(0, Math.Min(horizontal ? source.Width - 1 : source.Height - 1, index));

                        Color pixelColor = horizontal ? source.GetPixel(index, y) : source.GetPixel(x, index);
                        double weight = kernel[i];

                        r += pixelColor.R * weight;
                        g += pixelColor.G * weight;
                        b += pixelColor.B * weight;
                    }

                    destination.SetPixel(x, y, Color.FromArgb((int)r, (int)g, (int)b));
                }
            }
        }

        private static double[] CreateGaussianKernel(int radius, double deviation)
        {
            int size = 2 * radius + 1;
            double[] kernel = new double[size];
            double sum = 0;

            for (int i = -radius; i <= radius; i++)
            {
                double weight = Math.Exp(-(i * i) / (2 * deviation * deviation));
                kernel[i + radius] = weight;
                sum += weight;
            }

            for (int i = 0; i < size; i++)
            {
                kernel[i] /= sum;
            }

            return kernel;
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
            flowSideBar.Visible = true;
            flowImageEdited.Visible = true;

            flowFiltros.Visible = false;
            txtFilterValue.Visible = false;
            tbFilterValue.Visible = false;
            tbGamma1.Visible = false;
            tbGamma2.Visible = false;
            panelRGB.Visible = false;
            btnExport.Visible = false;
            panelCamara.Visible = false;
        }

        private void btnSharpen_Click(object sender, EventArgs e)
        {
            filtroActivo = "Sharpen";
            tbFilterValue.Visible = true;
            txtFilterValue.Visible = true;

            tbGamma1.Visible = false;
            tbGamma2.Visible = false;

            SharpenFilter();
        }

        private void btnBrightness_Click(object sender, EventArgs e)
        {
            filtroActivo = "Brightness";
            tbFilterValue.Visible = true;
            txtFilterValue.Visible = true;

            tbGamma1.Visible = false;
            tbGamma2.Visible = false;

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
                case "Blur":
                    GaussianBlurFilter(tbFilterValue.Value);
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

            tbGamma1.Visible = false;
            tbGamma2.Visible = false;

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

            tbGamma1.Visible = false;
            tbGamma2.Visible = false;

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

            tbGamma1.Visible = false;
            tbGamma2.Visible = false;

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

            tbGamma1.Visible = false;
            tbGamma2.Visible = false;

            tbFilterValue.Minimum = 1;
            tbFilterValue.Maximum = 10;
            tbFilterValue.Value = 5;

            GaussianBlurFilter(5);
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

            tbGamma1.Visible = false;
            tbGamma2.Visible = false;

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

            tbGamma1.Visible = false;
            tbGamma2.Visible = false;

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

            tbGamma1.Visible = false;
            tbGamma2.Visible = false;

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
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            Image<Bgr, byte> grayImage = new Image<Bgr, byte>(bitmap);
            Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.2, 1);
            
            foreach(Rectangle rectangle in rectangles)
            {
                using(Graphics graphics = Graphics.FromImage(bitmap))
                {
                    using(Pen pen = new Pen(Color.Red, 1))
                    {
                        graphics.DrawRectangle(pen, rectangle);
                    }
                }
            }
            
            pbCamera.Image = bitmap;
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
