using multipledashboard.Properties;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnPindah_Click(object sender, EventArgs e)
        {
            string usernameText = username.Text;
            string passwordText = password.Text;

            if (IsUsernameValid(usernameText) && IsPasswordValid(passwordText))
            {
                Home home = new Home(usernameText);
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
                username.Text = "";
                password.Text = "";
            }
        }

        private bool IsUsernameValid(string username)
        {
            return username == "alyaarana";
        }

        private bool IsPasswordValid(string password)
        {
            return password == "alyaa";
        }
    }
}
