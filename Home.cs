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
    public partial class Home : Form
    {

        private String username;


        public Home(String username)
        {
            InitializeComponent();
            resultUsn.Text =  "Hi, welcome " + username ;
        }

        private void UC_Item_Clicked(object sender, EventArgs e)
        {
            UC_Item selectedItem = (UC_Item)sender;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuRange1_RangeChanged(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {
            new Food(username).Show();
            this.Hide();
        }

        private void navFood_Click(object sender, EventArgs e)
        {
            new Food(username).Show();
            this.Hide();
        }

        private void navGallery_Click_1(object sender, EventArgs e)
        {
            new Gallery(username).Show();
            this.Hide();
        }

        private void navSetting_Click(object sender, EventArgs e)
        {
            new Settings(username).Show();
            this.Hide();
        }

        private void navHome_Click_1(object sender, EventArgs e)
        {
            new Home(username).Show();
            this.Hide();
        }
    }
}
