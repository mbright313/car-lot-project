using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotApp
{
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

        public Car(string carmake, string carmodel, double carmpg, decimal carprice)
        {
            make = carmake;
            model = carmodel;
            mpg = carmpg;
            price = carprice;
        }
    }
}
