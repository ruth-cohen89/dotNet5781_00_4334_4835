﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BLAPI;

namespace PL
{
    /// <summary>
    /// Interaction logic for BusDetails.xaml
    /// </summary>
    public partial class BusDetails : Window
    {
        IBL bl = BLFactory.GetBL("1");
        public BusDetails(BO.Bus bus)
        {
            InitializeComponent();
            busGrid.DataContext = bl.GetBus(bus.LicenseNum);
            
            
        }

        
    }
}
