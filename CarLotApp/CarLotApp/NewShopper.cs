using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CarLotApp
{
    public partial class NewShopper : Form
    {
        public NewShopper()
        {
            InitializeComponent();
        }

        /// <summary>
        /// sets new shopper name and money
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newShopperOkBtn_Click(object sender, EventArgs e)
        {
            if(decimal.TryParse(moneyText.Text, out decimal money))
            {
                Shopper shopper = new Shopper(nameText.Text, money);
                if (this.Owner is CarLotForm parentform)
                {
                    parentform.shopperName.Text = nameText.Text + ": ";
                    parentform.shopperMoney.Text = "$" + moneyText.Text;
                    parentform.newShopper(shopper);
                    parentform.Refresh();
                }
                Close();
            }
        }
    }
}
