/*

* Author: Blake Davies

* File name: OrderControl.Xaml.cs

* Purpose: to handle the events for the point of sale

*/
using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// initilizes a main window and creates the order as well as sets the order as datacontext
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            var data = new Order();

            this.DataContext = data;

        }

        /// <summary>
        /// handler for when the cancle order button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancleOrderButton_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        /// <summary>
        /// handler for when the new order button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewOrderButton_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }


    }
}
