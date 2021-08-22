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
    /// Interaction logic for BusDisplay.xaml
    /// </summary>
    public partial class BusDisplay : Window
    {
        IBL bl = BLFactory.GetBL("1");
        public BusDisplay()
        {
            
            InitializeComponent();
            busDataGrid.DataContext = bl.GetAlllBuses();
            busDataGrid.IsReadOnly = true;
        }
        private void Button_Click(object sender, RoutedEventArgs e)//will  open LineCrud window peulut nosfot
        {
            BusCrud window = new BusCrud();
            window.Show();
            window.Closed += Window_Closed;



        }
        private void Window_Closed(object sender, EventArgs e)
        {
            busDataGrid.DataContext = bl.GetAlllBuses();
          busDataGrid.IsReadOnly = true;
        }
        private void Details_Click(object sender, RoutedEventArgs e)//will  open LineCrud window peulut nosfot
        {
            BusDetails window = new BusDetails(busDataGrid.SelectedItem as BO.Bus);
            window.Show();
            window.Closed += Window_Closed;



        }

    }
}
