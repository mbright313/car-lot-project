using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotApp
{
    /// <summary>
    /// Represents a single car object within a CarLot
    /// </summary>
    internal class Car
    {
        /// <summary>
        /// make of the car object
        /// </summary>
        public string make { get; set; }
        /// <summary>
        /// model of the car object
        /// </summary>
        public string model { get; set; }
        /// <summary>
        /// Miles per gallon that the car object receives
        /// </summary>
        public double mpg { get; set; }
        /// <summary>
        /// price of car object
        /// </summary>
        public decimal price { get; set; }

        /// <summary>
        /// Creates a car object with a make, model, miles per gallon, and price property.
        /// </summary>
        /// <param name="carmake"></param>
        /// <param name="carmodel"></param>
        /// <param name="carmpg"></param>
        /// <param name="carprice"></param>
        public Car(string carmake, string carmodel, double carmpg, decimal carprice)
        {
            make = carmake;
            model = carmodel;
            mpg = carmpg;
            price = carprice;
        }
    }
}
