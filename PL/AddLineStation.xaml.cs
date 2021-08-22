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
    /// Interaction logic for AddLineStation.xaml
    /// </summary>
    public partial class AddLineStation : Window
    {
        private BO.LineStation station = new BO.LineStation();
        public AddLineStation()
        {
            InitializeComponent();
            LineStationGrid.DataContext = station;//new line station
            




        }

        public BO.LineStation NewStation { get { return station; } }//returns user input 

       
    }
}
