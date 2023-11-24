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
    public partial class Food : Form
    {
 
        private String username;

        public Food(string username)
        {
            InitializeComponent();
        }

        private void Food_Load(object sender, EventArgs e)
        {
            Item("Ramen", "ramen", 12);
            Item("Bread", "bread", 10);
            Item("Nugget", "nugget", 12);
            Item("Noodle Nugget", "nugget noodles", 10);
            Item("Pizza", "pizza", 18);
            Item("Fried Shrimp", "stir-fried shrimp", 10);
            Item("Pancake", "pancake", 10);
            Item("Noodles", "noodle", 17);


        }


        private void navHome_Click_1(object sender, EventArgs e)
        {
            new Home(username).Show();
            this.Hide();
        }
        private void navRecipe_Click_1(object sender, EventArgs e)
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void uC_Item1_Load_1(object sender, EventArgs e)
        {

        }

        private void navGallery_Click(object sender, EventArgs e)
        {
            new Gallery(username).Show();
            this.Hide();
        }

        private void navHome_Click(object sender, EventArgs e)
        {
            new Home(username).Show();
            this.Hide();
        }

        public void Item(string itemName, string imageName, double itemPrice)
        {
            // Load the image from resources
            Image itemImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);

            // Add a new UC_Item to the panel
            var w = new UC_Item()
            {
                itemName = itemName,
                itemImage = itemImage,
                itemPrice = itemPrice,
                Margin = new Padding(8)
            };

            // Log the current height before adding the new item
            Console.WriteLine($"Before adding {itemName}, panel height: {flowLayoutPanel1.Height}");

            flowLayoutPanel1.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (UC_Item)ss;
                foreach (DataGridViewRow item in grid.Rows)
                {
                    // Assuming item.Cells[0].Value is the name of the item
                    if (item.Cells[0].Value != null && item.Cells[0].Value.ToString() == wdg.itemName)
                    {
                        item.Cells[1].Value = int.Parse(item.Cells[1].Value.ToString()) + 1;
                        item.Cells[2].Value = (int.Parse(item.Cells[1].Value.ToString()) * double.Parse(item.Cells[2].Value.ToString().Replace("$", ""))).ToString();
                        CalculateTotal();
                        return;
                    }
                }

                grid.Rows.Add(new object[] { wdg.itemName, 1, wdg.itemPrice });
                CalculateTotal();

                // Log the current height after adding the new item
                Console.WriteLine($"After adding {itemName}, panel height: {flowLayoutPanel1.Height}");
            };
        }




        /*public void Item(string itemName, string imageName, double itemPrice)
        {
            // Load the image from resources
            Image itemImage = Properties.Resources.ResourceManager.GetObject(imageName) as Image;

            // Add a new UC_Item to the panel
            *//*panel5.Controls.Add(new UC_Item()
            {
                itemName = itemName,
                itemImage = itemImage,
                itemPrice = itemPrice,
            });*//*

            var w = new UC_Item()
            {
                itemName = itemName,
                itemImage = itemImage,
                itemPrice = itemPrice,
            };
            panel5.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (UC_Item)ss;
                foreach (DataGridViewRow item in grid.Rows)
                {
                    // Assuming item.Cells[0].Value is the name of the item
                    if (item.Cells[0].Value != null && item.Cells[0].Value.ToString() == wdg.itemName)
                    {
                        item.Cells[1].Value = int.Parse(item.Cells[1].Value.ToString()) + 1;
                        item.Cells[2].Value = (int.Parse(item.Cells[1].Value.ToString()) * double.Parse(item.Cells[2].Value.ToString().Replace("$", ""))).ToString();
                        CalculateTotal();
                        return;
                    }
                }

                grid.Rows.Add(new object[] { wdg.itemName, 1, wdg.itemPrice });
                CalculateTotal();
            };

        }*/

        private void CalculateTotal()
        {
            double total = 0;

            foreach (DataGridViewRow item in grid.Rows)
            {
                if (item.Cells[2].Value != null)
                {
                    total += double.Parse(item.Cells[2].Value.ToString().Replace("$", ""));
                }
            }

            // Update your total display or perform any other necessary actions
            // For example, if you have a label to display the total:
            lblTotal.Text = total.ToString("C2");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            /*            panel5.Controls.Clear();*/

            // Jika Anda juga ingin mengosongkan grid dan total, tambahkan pernyataan berikut:
            txtComment.Text = "";
            grid.Rows.Clear();
            lblTotal.Text = "$0.00";

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void navSetting_Click(object sender, EventArgs e)
        {
            new Settings(username).Show();
            this.Hide();
        }
    }
}
