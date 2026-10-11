using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace CarLotApp
{
    internal class Driver
    {
        /// <summary>
        /// Main entry point to program
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Car honda = new Car("honda", "accord", 24.0, 13000);
        }
    }
}
