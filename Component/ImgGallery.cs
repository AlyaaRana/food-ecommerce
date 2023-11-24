using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multipledashboard.Component
{
    public partial class ImgGallery : UserControl
    {
        public ImgGallery()
        {
            InitializeComponent();
        }

        // Properti Image untuk mengakses gambar dari luar
        public Image Image
        {
            get { return pb_gallery.Image; }
            set { pb_gallery.Image = value; }
        }

        // Metode untuk mengatur gambar dari luar
        public void SetImage(Image image)
        {
            pb_gallery.Image = image;
        }

        private void pb_gallery_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png"; // Filter untuk menampilkan hanya file gambar

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Dapatkan path gambar yang dipilih
                string imagePath = openFileDialog.FileName;

                // Load gambar dari path dan set sebagai gambar di PictureBox
                pb_gallery.Image = Image.FromFile(imagePath);
            }
        }
    }
}
