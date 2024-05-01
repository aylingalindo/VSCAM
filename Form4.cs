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
    public partial class Histogram : Form
    {
        private int[] histogramRed;
        private int[] histogramGreen;
        private int[] histogramBlue;
        private int mayorR;
        private int mayorG;
        private int mayorB;

        public Histogram(int[] pHistogramR, int[] pHistogramG, int[] pHistogramB)
        {
            InitializeComponent();
            histogramRed = pHistogramR;
            histogramGreen = pHistogramG;
            histogramBlue = pHistogramB;
            int n = 0;

            mayorR = 0;
            mayorG = 0;
            mayorB = 0;
            for (n = 0; n < 256; n++)
            {
                if (histogramRed[n] > mayorR)
                    mayorR = histogramRed[n];
                if (histogramGreen[n] > mayorG)
                    mayorG = histogramGreen[n];
                if (histogramBlue[n] > mayorB)
                    mayorB = histogramBlue[n];
            }

            for (n = 0; n < 256; n++)
            {
                histogramRed[n] = (int)((float)histogramRed[n] / (float)mayorR * 256.0f);
                histogramGreen[n] = (int)((float)histogramGreen[n] / (float)mayorG * 256.0f);
                histogramBlue[n] = (int)((float)histogramBlue[n] / (float)mayorB * 256.0f);
            }
        }

        private void Histogram_Paint(object sender, PaintEventArgs e)
        {
            int n = 0;
            int altura = 0;
            Graphics g = e.Graphics;
            Pen redPen = new Pen(Color.Red);
            Pen greenPen = new Pen(Color.Green);
            Pen bluePen = new Pen(Color.Blue);
            Pen axisPen = new Pen(Color.Coral);

            g.DrawLine(axisPen, 19, 271, 277, 271);
            g.DrawLine(axisPen, 19, 270, 19, 14);

            for (n = 0; n < 256; n++)
            {
                g.DrawLine(redPen, n + 20, 270, n + 20, 270 - histogramRed[n]);
                g.DrawLine(greenPen, n + 20, 270, n + 20, 270 - histogramGreen[n]);
                g.DrawLine(bluePen, n + 20, 270, n + 20, 270 - histogramBlue[n]);
            }
        }
    }
}


