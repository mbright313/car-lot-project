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
        public CarLotForm()
        {
            CarLot lot = new CarLot();
            InitializeComponent();
        }
    }
}
