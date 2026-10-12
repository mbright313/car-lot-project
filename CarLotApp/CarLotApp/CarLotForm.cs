using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CarLotApp
{
    public partial class CarLotForm : Form
    {
        CarLot lot = new CarLot();
        public CarLotForm()
        {
            InitializeComponent();
            foreach (Car car in lot.Inventory)
            {
                string info = car.toString();
                listBox1.Items.Add(info);
            }
        }

        private void createShopperbtn_Click(object sender, EventArgs e)
        {
            NewShopper shop = new NewShopper();
            shop.Show(this);
        }

        private void addCarbtn_Click(object sender, EventArgs e)
        {
            AddCarForm addCarForm = new AddCarForm(lot.Inventory);
            addCarForm.Show(this);
        }

        public void addCartoList(Car car)
        {
            listBox1.Items.Add(car.toString());
            Refresh();
        }
    }
}
