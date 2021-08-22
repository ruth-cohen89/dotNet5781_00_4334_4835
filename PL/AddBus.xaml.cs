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

namespace PL
{
    /// <summary>
    /// Interaction logic for AddBus.xaml
    /// </summary>
    public partial class AddBus : Window
    {
        private BO.Bus bus = new BO.Bus();
        public AddBus()
        {
            InitializeComponent();
            busGrid.DataContext = bus;
            
        }
        public BO.Bus NewBus{ get { return bus; } }//returns user input 


    }
}
