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
    public partial class Gallery : Form
    {
        private string username;
        
        public Gallery(string usernam)
        {
            InitializeComponent();
            this.username = username;


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
            this.Hide();
        }

        private void navSetting_Click_1(object sender, EventArgs e)
        {
            new Settings(username).Show();
            this.Hide();
        }

        private void imgGallery1_Load(object sender, EventArgs e)
        {

        }

        private void imgGallery1_Load_1(object sender, EventArgs e)
        {

        }
    }
}

