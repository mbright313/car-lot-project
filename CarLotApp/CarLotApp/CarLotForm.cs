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
    public partial class CarLotForm : Form
    {
        /// <summary>
        /// CarLot to contain the full inventory of cars
        /// </summary>
        CarLot lot = new CarLot();

        /// <summary>
        /// Shopper details
        /// </summary>
        Shopper shop;

        /// <summary>
        /// Create new CarLotForm and initialize list box and shopper
        /// </summary>
        public CarLotForm()
        {
            InitializeComponent();
            shop = new Shopper("No Shopper", 0);
            foreach (Car car in lot.Inventory)
            {
                string info = car.toString();
                listBox1.Items.Add(info);
            }
        }

        /// <summary>
        /// Pulls up NewShopper form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createShopperbtn_Click(object sender, EventArgs e)
        {
            NewShopper shop = new NewShopper();
            shop.Show(this);
        }

        /// <summary>
        /// Pulls up AddCar form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addCarbtn_Click(object sender, EventArgs e)
        {
            AddCarForm addCarForm = new AddCarForm(lot.Inventory);
            addCarForm.Show(this);
        }

        /// <summary>
        /// Adds a car to the listbox in the form
        /// </summary>
        /// <param name="car"></param>
        public void addCartoList(Car car)
        {
            listBox1.Items.Add(car.toString());
            lot.Inventory.Add(car);
            refreshForm();
        }

        /// <summary>
        /// sets the current shopper to a new shopper
        /// </summary>
        /// <param name="shopper"></param>
        public void newShopper(Shopper shopper)
        {
            shop = shopper;
        }

        /// <summary>
        /// Updates shopper name and money
        /// </summary>
        private void refreshForm()
        {
            shopperName.Text = shop.name;
            shopperMoney.Text = "$" + shop.moneyAvailable;
        }

        /// <summary>
        /// Allows shopper to purchase a car if they have enough money
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void purchaseBtn_Click(object sender, EventArgs e)
        {
            string carinfo = (string)listBox1.Items[listBox1.SelectedIndex];
            string[] splitCarInfo = carinfo.Split("mpg | $");
            string[] carMakeModel = splitCarInfo[0].Split(" ");
            if (decimal.TryParse(splitCarInfo[1], out decimal carPrice))
            {
                if (shop.CanPurchase(carPrice))
                {
                    shop.PurchaseCar(lot.Inventory[listBox1.SelectedIndex], carPrice);
                    lot.PurchaseCar(carMakeModel[0], carMakeModel[1]);
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    listBox1.Refresh();
                    refreshForm();
                    MessageBox.Show("Congratulations on your new car!");
                }
                else
                {
                    MessageBox.Show("Shopper does not have enough funds.");
                }
            }

        }

        /// <summary>
        /// Shows details of current inventory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void invBtn_Click(object sender, EventArgs e)
        {
            string details = "Inventory of " + lot.Inventory.Count + " cars:";
            foreach (Car car in lot.Inventory)
            {
                details += "\n" + car.toString();
            }
            details += "\n\n" + "Most Expensive: " + "\n" + lot.FindMostExpensiveCar().toString() + "\n";
            details += "\n" + "Least Expensive: " + "\n" + lot.FindLeastExpensiveCar().toString() + "\n";
            details += "\n" + "Best MPG: " + "\n" + lot.FindBestMPG().toString() + "\n";
            details += "\n" + "Worst MPG: " + "\n" + lot.FindWorstMPG().toString() + "\n";
            MessageBox.Show(details);
        }
    }
}
