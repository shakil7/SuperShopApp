using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperShopApp.BLL;
using SuperShopApp.DLL.DAO;

namespace SuperShopApp
{
    public partial class ShopAppUI : Form
    {
        ShopBLL aShopBLL=new ShopBLL();
        public ShopAppUI()
        {
            InitializeComponent();
        }

        private void saveShopButton_Click(object sender, EventArgs e)
        {
            Shop aShop=new Shop(shopNameTextBox.Text,shopAddressTextBox.Text);
            string msg = aShopBLL.Save(aShop);
            MessageBox.Show(msg);
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            Item anItem=new Item(itemIdTextBox.Text, Convert.ToInt32(qtyTextBox.Text));
            string msg = aShopBLL.AddItem(anItem);
            MessageBox.Show(msg);

        }

        
    }
}
