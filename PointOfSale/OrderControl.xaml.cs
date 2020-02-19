/*

* Author: Blake Davies

* File name: OrderControl.Xaml.cs

* Purpose: to handle the events for the point of sale

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
        }

        //Entree Events

        /// <summary>
        /// event handler for the angry chicken button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAngryChickenButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListBox.Items.Add(new AngryChicken());
        }

        /// <summary>
        /// event hander for the cowpoke chili button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowPokeChiliButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListBox.Items.Add(new CowpokeChili());
        }

        /// <summary>
        /// event handler for the dakota double burger button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDakotaDoubleBurger_Click(object sender, RoutedEventArgs e)
        {
            OrderListBox.Items.Add(new DakotaDoubleBurger());
        }

        /// <summary>
        /// event handler for the pulled pork button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPecosPulledPorkButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListBox.Items.Add(new PecosPulledPork());
        }

        /// <summary>
        /// event hanlder for the rustler's ribs button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRustlersRibsButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListBox.Items.Add(new RustlersRibs());
        }

        /// <summary>
        /// event handler for the texas triple burger button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTripleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListBox.Items.Add(new TexasTripleBurger());
        }


        //sides buttons
        
        /// <summary>
        /// even handler for the add baked beans button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBakedBeansButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListBox.Items.Add(new BakedBeans());
        }

        /// <summary>
        /// event hanldre for the chili cheese fries button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddChiliCheeseFriesButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListBox.Items.Add(new ChiliCheeseFries());
        }

        /// <summary>
        /// event handler for the Cordn Dodgers button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCornDodgersButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListBox.Items.Add(new CornDodgers());
        }

        /// <summary>
        /// event handler for the pan de campo button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPanDeCampoButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListBox.Items.Add(new PanDeCampo());
        }

        //Drinks Event handlers

        /// <summary>
        /// event handler for the cowboy coffee button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowboyCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListBox.Items.Add(new CowboyCoffee());
        }

        /// <summary>
        /// event handler for the jerked soda button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddJerkedSodaButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListBox.Items.Add(new JerkedSoda());
        }

        /// <summary>
        /// event handler for the texas tea button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTeaButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListBox.Items.Add(new TexasTea());
        }

        /// <summary>
        /// event handler for the water button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddWaterButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListBox.Items.Add(new Water());
        }
    }
}
