﻿using System;
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
    /// Interaction logic for CowBoyCoffeeCustomizer.xaml
    /// </summary>
    public partial class CowBoyCoffeeCustomizer : UserControl
    {
        public CowBoyCoffeeCustomizer()
        {
            InitializeComponent();
        }


        private void SmallButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CowboyCoffee data)
            {
                data.Size = CowboyCafe.Data.Size.Small;
            }
        }

        private void MediumButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CowboyCoffee data)
            {
                data.Size = CowboyCafe.Data.Size.Medium;
            }
        }

        private void LargeButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CowboyCoffee data)
            {
                data.Size = CowboyCafe.Data.Size.Large;
            }
        }

        private void IceButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CowboyCoffee data)
            {
                if (data.Ice)
                {
                    data.Ice = false;
                }
                else
                {
                    data.Ice = true;
                }
            }
        }

        private void RoomForCreamButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CowboyCoffee data)
            {
                if (data.RoomForCream)
                {
                    data.RoomForCream = false;
                }
                else
                {
                    data.RoomForCream = true;
                }
            }
        }

        private void DecafButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CowboyCoffee data)
            {
                if (data.Decaf)
                {
                    data.Decaf = false;
                }
                else
                {
                    data.Decaf = true;
                }
            }
        }

    }
}
