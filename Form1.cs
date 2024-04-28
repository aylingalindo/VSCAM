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
            file.Filter = "archivos de imagenes (*.png; *.jpg)| *.png; *.jpg";

            if (file.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmapImage = null;
                try
                {
                    if (IsImageFile(file.FileName))
                    {
                        bitmapImage = new Bitmap(file.FileName);
                        original = bitmapImage;
                        formVsCam form2 = new formVsCam(bitmapImage);
                        form2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid image file.");
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
    }
}
