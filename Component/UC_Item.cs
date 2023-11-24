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

    /*public enum categories { burger, kentang, sosis, mie, ayam,telur}*/
    public partial class UC_Item : UserControl
    {
        public event EventHandler onSelect = null;
        private double _price;

        public UC_Item()
        {
            InitializeComponent();
           
        }
/*        public categories Category
        {
            get { categories};
            set { categories};
        }*/
        public Image itemImage
        {
            get { return imgItem.Image; }
            set { imgItem.Image = value; }
        }

        public String itemName
        {
            get { return lblItemName.Text; }
            set { lblItemName.Text = value; }
        }

        public double itemPrice
        {

            get => _price;
            set { _price = value; lblItemPrice.Text = _price.ToString("C2"); }
        }

        public string Title { get; internal set; }
        public double Price { get; internal set; }
        public Image Img { get; internal set; }

        private void UC_Item_Load(object sender, EventArgs e)
        {

        }

/*        private void imgItem_Click(object sender, EventArgs e)
        {
            // Open a file dialog to select an image
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png";
        }*/

        private void imgItem_Click_1(object sender, EventArgs e)
        {
            
            onSelect?.Invoke(this,e);
        }

        private void lblItemPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
