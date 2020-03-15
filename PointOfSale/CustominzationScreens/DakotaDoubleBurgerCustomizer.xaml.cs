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
    /// Interaction logic for DakotaDoubleBurgerCustomizer.xaml
    /// </summary>
    public partial class DakotaDoubleBurgerCustomizer : UserControl
    {
        public DakotaDoubleBurgerCustomizer()
        {
            InitializeComponent();
        }

        private void ToggleBunButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is DakotaDoubleBurger data)
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
            if (DataContext is DakotaDoubleBurger data)
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
            if (DataContext is DakotaDoubleBurger data)
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
            if (DataContext is DakotaDoubleBurger data)
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
            if (DataContext is DakotaDoubleBurger data)
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

        private void ToggleMayoButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is DakotaDoubleBurger data)
            {
                if (data.Mayo)
                {
                    data.Mayo = false;
                }
                else
                {
                    data.Mayo = true;
                }
            }
        }

        private void ToggleLettuceButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is DakotaDoubleBurger data)
            {
                if (data.Lettuce)
                {
                    data.Lettuce = false;
                }
                else
                {
                    data.Lettuce = true;
                }
            }
        }

        private void ToggleTomatoButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is DakotaDoubleBurger data)
            {
                if (data.Tomato)
                {
                    data.Tomato = false;
                }
                else
                {
                    data.Tomato = true;
                }
            }
        }
    }
}
