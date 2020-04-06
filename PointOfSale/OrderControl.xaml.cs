/*

* Author: Blake Davies

* File name: OrderControl.Xaml.cs

* Purpose: to handle the design and databinding of the point of sale

*/
using System;
using System.Collections.Generic;
using System.Text;
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
using PointOfSale.ExtensionMethods;
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
            var data = new Order();
            
            this.DataContext = data;

            var cashdrawer = new CashDrawer();
        }

        /// <summary>
        /// handler for when the cancle order button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancleOrderButton_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }

        /// <summary>
        /// handler for when the new order button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompleteOrderButton_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = this.FindAncestor<MainWindow>();
            mainwindow.SwapScreen(new TransactionControl((Order)DataContext));
        }




        public void SwapScreen(FrameworkElement element)
        {
            ScreenHousing.Child = element;
        }

        private void ItemSelectionButton_Click(object sender, RoutedEventArgs e)
        {
            ScreenHousing.Child = new MenuItemSelectioncontrols();
        }

        public void Reset()
        {
            this.DataContext = new Order();
            ScreenHousing.Child = new MenuItemSelectioncontrols();
        }
    }
}
