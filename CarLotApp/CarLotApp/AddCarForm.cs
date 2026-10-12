using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace CarLotApp
{
    public partial class AddCarForm : Form
    {
        List<Car> lotInv;
        public AddCarForm(List<Car> inv)
        {
            lotInv = new List<Car>(inv);
            InitializeComponent();
        }

        private void addCarOKBtn_Click(object sender, EventArgs e)
        {
            if(double.TryParse(mpgBox.Text, out double mpg) && decimal.TryParse(priceBox.Text, out decimal price))
            {
                if(this.Owner is CarLotForm parentform)
                {
                    Car newCar = new Car(makeBox.Text, modelBox.Text, mpg, price);
                    parentform.addCartoList(newCar);
                    Close();
                }
            }
            else
            {
                Debug.WriteLine("parse fail");
            }
        }
    }
}
