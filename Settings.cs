using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multipledashboard
{
    public partial class Settings : Form
    {
        private String username;
        private IEnumerable<UC_Item> selectedItems;

        public Settings(string username)
        {
            InitializeComponent();
        }

        private void navHome_Click(object sender, EventArgs e)
        {

            new Home(username).Show();
            this.Hide();
        }

        private void navGallery_Click(object sender, EventArgs e)
        {
            new Gallery(username).Show();
            this.Hide();
        }

        private void navFood_Click_1(object sender, EventArgs e)
        {

            new Food(username).Show();
            this.Hide() ;
        }

        private void navSetting_Click(object sender, EventArgs e)
        {
            new Settings(username).Show();
            this.Hide();
        }


        private void navLogout_Click_1(object sender, EventArgs e)
        {
            /*            new Login().Show();
                        this.Hide();*/
            DialogResult dialogResult = MessageBox.Show("Yakin Ingin Keluar ? ", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                //Close();
                Application.Exit();
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load the image into the PictureBox control
                pictureBox6.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void navGallery_Click_1(object sender, EventArgs e)
        {
            new Gallery(username).Show();
            this.Hide();
        }

        private void navFood_Click(object sender, EventArgs e)
        {
            new Food(username).Show();
            this.Hide();
        }

        private void navHome_Click_1(object sender, EventArgs e)
        {
            new Home(username).Show();
            this.Hide();
        }

        private void navSetting_Click_1(object sender, EventArgs e)
        {
            new Settings(username).Show();
            this.Hide();
        }
    }
}
