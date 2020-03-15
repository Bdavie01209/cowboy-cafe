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

namespace PointOfSale.CustominzationScreens
{
    /// <summary>
    /// Interaction logic for TrailBurgerCustomizer.xaml
    /// </summary>
    public partial class TrailBurgerCustomizer : UserControl
    {
        public TrailBurgerCustomizer()
        {
            InitializeComponent();
        }

        private void ToggleBunButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is TrailBurger data)
            {
                if (data.Bun)
                {
                    data.Bun = false;
                }
                else
                {
                    data.Bun = true;
                }
            }
        }

        private void ToggleKetchupButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is TrailBurger data)
            {
                if (data.Ketchup)
                {
                    data.Ketchup = false;
                }
                else
                {
                    data.Ketchup = true;
                }
            }
        }

        private void ToggleMustardButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is TrailBurger data)
            {
                if (data.Mustard)
                {
                    data.Mustard = false;
                }
                else
                {
                    data.Mustard = true;
                }
            }
        }

        private void TogglePickleButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is TrailBurger data)
            {
                if (data.Pickle)
                {
                    data.Pickle = false;
                }
                else
                {
                    data.Pickle = true;
                }
            }
        }

        private void ToggleCheeseButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is TrailBurger data)
            {
                if (data.Cheese)
                {
                    data.Cheese = false;
                }
                else
                {
                    data.Cheese = true;
                }
            }
        }
    }
}
