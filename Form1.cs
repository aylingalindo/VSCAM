using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace vscam
{
    public partial class Home : Form
    {
        public Bitmap original;

        public Home()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Archivos de imagen (*.png; *.jpg)|*.png;*.jpg|Archivos de video (*.mp4; *.avi)|*.mp4;*.avi";

            if (file.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmapImage = null;
                try
                {
                    if (IsImageFile(file.FileName))
                    {
                        bitmapImage = new Bitmap(file.FileName);
                        original = bitmapImage;
                        formVsCam form2 = new formVsCam(bitmapImage, null);
                        form2.Show();
                        this.Hide();
                    }else if (IsVideoFile(file.FileName))
                    {
                        VideoCapture capture = new VideoCapture(file.FileName);
                        formVsCam form2 = new formVsCam(null, capture);
                        form2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid image or video file.");
                    }
                }
                 catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
                finally
                {
                    if (bitmapImage != null)
                    {
                        bitmapImage.Dispose(); // Dispose of the Bitmap object
                    }
                }
            }

        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private bool IsImageFile(string filePath)
        {
            string extension = Path.GetExtension(filePath);
            return !string.IsNullOrEmpty(extension) &&
                   (extension.Equals(".png", StringComparison.OrdinalIgnoreCase) ||
                    extension.Equals(".jpg", StringComparison.OrdinalIgnoreCase));
        }

        private bool IsVideoFile(string filePath)
        {
            string extension = Path.GetExtension(filePath);
            return !string.IsNullOrEmpty(extension) &&
                   (extension.Equals(".mp4", StringComparison.OrdinalIgnoreCase) ||
                    extension.Equals(".avi", StringComparison.OrdinalIgnoreCase));
        }
    }
}
