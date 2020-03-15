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
using PointOfSale.CustominzationScreens;
using PointOfSale.ExtensionMethods;


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class MenuItemSelectioncontrols : UserControl
    {
        public MenuItemSelectioncontrols()
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
            if (DataContext is Order order)
            {
                var item = new AngryChicken();
                order.Add(item);
                var ordercontrol = this.FindAncestor<OrderControl>();
                ordercontrol.SwapScreen(new AngryChickenCustomizer() { DataContext = item });
            }
        }

        /// <summary>
        /// event hander for the cowpoke chili button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowPokeChiliButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                var item = new CowpokeChili();
                order.Add(item);
                var ordercontrol = this.FindAncestor<OrderControl>();

                ordercontrol.SwapScreen(new CowpokeChiliCustomizer() {DataContext = item });

            }
        }

        /// <summary>
        /// event handler for the dakota double burger button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDakotaDoubleBurger_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                var item = new DakotaDoubleBurger();
                order.Add(item);
                var ordercontrol = this.FindAncestor<OrderControl>();

                ordercontrol.SwapScreen(new DakotaDoubleBurgerCustomizer() { DataContext = item });
            }
        }

        /// <summary>
        /// event handler for the pulled pork button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPecosPulledPorkButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                var item = new PecosPulledPork();
                order.Add(item);

                var ordercontrol = this.FindAncestor<OrderControl>();

                var customizer = new PescoPulledPorkCustomizer();

                customizer.DataContext = item;

                ordercontrol.SwapScreen(customizer);
            }
        }

        /// <summary>
        /// handler for trail burger button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTrailBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                var item = new TrailBurger();
                order.Add(item);

                var ordercontrol = this.FindAncestor<OrderControl>();

                var customizer = new TrailBurgerCustomizer();

                customizer.DataContext = item;

                ordercontrol.SwapScreen(customizer);
            }
        }

        /// <summary>
        /// event hanlder for the rustler's ribs button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRustlersRibsButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new RustlersRibs());
            }
        }

        /// <summary>
        /// event handler for the texas triple burger button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTripleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                var item = new TexasTripleBurger();
                order.Add(item);

                var ordercontrol = this.FindAncestor<OrderControl>();

                var customizer = new TexasTripleBurgerCustomizer();

                customizer.DataContext = item;

                ordercontrol.SwapScreen(customizer);
            }
        }


        //sides buttons
        
        /// <summary>
        /// even handler for the add baked beans button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBakedBeansButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                var item = new BakedBeans();
                order.Add(item);
                var ordercontrol = this.FindAncestor<OrderControl>();

                ordercontrol.SwapScreen(new SideCustomizer() { DataContext = item });
            }
        }

        /// <summary>
        /// event hanldre for the chili cheese fries button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddChiliCheeseFriesButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                var item = new ChiliCheeseFries();
                order.Add(item);
                var ordercontrol = this.FindAncestor<OrderControl>();

                ordercontrol.SwapScreen(new SideCustomizer() { DataContext = item });
            }
        }

        /// <summary>
        /// event handler for the Cordn Dodgers button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCornDodgersButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                var item = new CornDodgers();
                order.Add(item);
                var ordercontrol = this.FindAncestor<OrderControl>();

                ordercontrol.SwapScreen(new SideCustomizer() { DataContext = item });
            }
        }

        /// <summary>
        /// event handler for the pan de campo button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPanDeCampoButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                var item = new PanDeCampo();
                order.Add(item);
                var ordercontrol = this.FindAncestor<OrderControl>();

                ordercontrol.SwapScreen(new SideCustomizer() { DataContext = item });
            }
        }

        //Drinks Event handlers

        /// <summary>
        /// event handler for the cowboy coffee button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowboyCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                var item = new CowboyCoffee();
                order.Add(item);
                var ordercontrol = this.FindAncestor<OrderControl>();

                ordercontrol.SwapScreen(new CowBoyCoffeeCustomizer() { DataContext = item });
            }
        }

        /// <summary>
        /// event handler for the jerked soda button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddJerkedSodaButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                var item = new JerkedSoda();
                order.Add(item);
                var ordercontrol = this.FindAncestor<OrderControl>();

                ordercontrol.SwapScreen(new JerkedSodaCustomizer() { DataContext = item });
            }
        }

        /// <summary>
        /// event handler for the texas tea button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTeaButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                var item = new TexasTea();
                order.Add(item);
                var ordercontrol = this.FindAncestor<OrderControl>();

                ordercontrol.SwapScreen(new TexasTeaCustomizer() { DataContext = item });
            }
        }

        /// <summary>
        /// event handler for the water button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddWaterButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                var item = new Water();
                order.Add(item);
                var ordercontrol = this.FindAncestor<OrderControl>();

                ordercontrol.SwapScreen(new WaterCustomizer() { DataContext = item });
            }
        }


    }
}
