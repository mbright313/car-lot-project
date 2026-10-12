using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CarLotApp
{
    internal class CarLot
    {
        /// <summary>
        /// Inventory of cars in carlot
        /// </summary>
        private List<Car> inventory;

        /// <summary>
        /// tax rate to calculate total cost
        /// </summary>
        public const decimal TAX_RATE = 0.078m;

        /// <summary>
        /// Creates a CarLot object and populates it with cars.
        /// </summary>
        public CarLot()
        {
            inventory = new List<Car>();
            StockLotWithDefaultInventory();
        }

        /// <summary>
        /// Stocks a CarLot inventory with Cars
        /// </summary>
        private void StockLotWithDefaultInventory()
        {
            inventory.Add(new Car("Ford", "Focus ST", 28.3, 26298.98m));
            inventory.Add(new Car("Chevrolet", "Camaro ZL1", 19.0, 65401.23m));
            inventory.Add(new Car("Honda", "Accord Sedan EX", 30.2, 26780.00m));
            inventory.Add(new Car("Lexus", "ES 350", 24.1, 42101.10m));
        }

        /// <summary>
        /// returns a list of Car objects with a specified make
        /// </summary>
        /// <param name="findMake"></param>
        /// <returns></returns>
        public List<Car> FindCarsByMake(string findMake)
        {
            //car list that will contain search results
            List<Car> carSearch = new List<Car>();
            foreach (Car car in inventory)
            {
                string carmake = car.make.ToLower();
                if(carmake.Equals(findMake.ToLower()))
                {
                    carSearch.Add(car);
                }
            }
            return carSearch;
        }

        /// <summary>
        /// returns a list of Car objects with a specified make and model
        /// </summary>
        /// <param name="findMake"></param>
        /// <param name="findModel"></param>
        /// <returns></returns>
        public Car FindCarByMakeModel(string findMake, string findModel)
        {
            foreach (Car car in inventory)
            {
                string carmake = car.make.ToLower();
                Debug.WriteLine(car.make + " " + findMake);
                Debug.WriteLine(carmake.Equals(findMake.ToLower()));
                string carmodel = car.model.ToLower();
                Debug.WriteLine(car.model + " " + findModel);
                Debug.WriteLine(carmodel.Equals(findModel.ToLower()));
                //carmake.Equals(findMake.ToLower()) && carmodel.Equals(findModel.ToLower())
                if (car.make.Equals(findMake) && car.model.Equals(findModel))
                {
                    return car;
                }
            }
            return null;
        }

        /// <summary>
        /// Searches for a car using FindCarByMakeModel and removes it from the inventory if found.
        /// </summary>
        /// <param name="findMake"></param>
        /// <param name="findModel"></param>
        /// <returns></returns>
        public Car PurchaseCar(string findMake, string findModel)
        {
            Car car = FindCarByMakeModel(findMake, findModel);
            if(car != null)
            {
                inventory.Remove(car);
                Debug.WriteLine("Removed " + car.toString());
            }
            return car;
        }

        /// <summary>
        /// Creates a new Car object and adds it to the CarLot inventory
        /// </summary>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="mpg"></param>
        /// <param name="price"></param>
        public void AddCar(string make, string model, double mpg, decimal price)
        {
            inventory.Add(new Car(make, model, mpg, price));
        }

        /// <summary>
        /// Adds a premade Car object to the CarLot inventory
        /// </summary>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="mpg"></param>
        /// <param name="price"></param>
        public void AddCar(Car car)
        {
            inventory.Add(car);
        }

        /// <summary>
        /// Returns total cost of purchase including tax
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        public decimal GetTotalCostOfPurchase(Car car)
        {
            return car.price * (1m + TAX_RATE);
        }

        /// <summary>
        /// sorts by price ascending and returns the first result
        /// </summary>
        /// <returns></returns>
        public Car FindLeastExpensiveCar()
        {
            return inventory.OrderBy(car => car.price).First();
        }

        /// <summary>
        /// sorts by price in descending order and returns the first result
        /// </summary>
        /// <returns></returns>
        public Car FindMostExpensiveCar()
        {
            return inventory.OrderByDescending(car => car.price).First();
        }

        /// <summary>
        /// sorts by mpg descending and returns the first result
        /// </summary>
        /// <returns></returns>
        public Car FindBestMPG()
        {
            return inventory.OrderByDescending(car => car.mpg).First();
        }

        /// <summary>
        /// sorts by mpg in ascending order and returns the first result
        /// </summary>
        /// <returns></returns>
        public Car FindWorstMPG()
        {
            return inventory.OrderBy(car => car.mpg).First();
        }

        /// <summary>
        /// returns number of cars in inventory
        /// </summary>
        public int invCount => inventory.Count;

        /// <summary>
        /// Returns inventory List
        /// </summary>
        public List<Car> Inventory => inventory;
    }
}
