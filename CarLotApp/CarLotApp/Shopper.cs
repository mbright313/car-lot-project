using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotApp
{
    public class Shopper
    {
        /// <summary>
        /// name of shopper
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// How much money a shopper has
        /// </summary>
        public decimal moneyAvailable { get; set; }

        /// <summary>
        /// List of car objects
        /// </summary>
        private List<Car> cars;

        /// <summary>
        /// creates a shopper object with a specified name and amount of money
        /// </summary>
        /// <param name="newName"></param>
        /// <param name="money"></param>
        public Shopper(string newName, decimal money)
        {
            name = newName;
            moneyAvailable = money;
            cars = new List<Car>();
        }

        /// <summary>
        /// Checks whether the shopper has enough money to make a purchase
        /// </summary>
        /// <param name="cost"></param>
        /// <returns></returns>
        public bool CanPurchase(decimal cost)
        {
            if (cost > moneyAvailable)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Adds car to the shopper's list of cars and deducts the cost from moneyAvailable
        /// </summary>
        /// <param name="car"></param>
        /// <param name="cost"></param>
        public void PurchaseCar(Car car, decimal cost)
        {
            cars.Add(car);
            moneyAvailable -= cost;
        }
    }
}
