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
    /// Interaction logic for JerkedSodaCustomizer.xaml
    /// </summary>
    public partial class JerkedSodaCustomizer : UserControl
    {
        public JerkedSodaCustomizer()
        {
            InitializeComponent();
        }


        private void HandleCheck(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
        }

        private void CreamSodaButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda data)
            {
                data.Flavor = CowboyCafe.Data.SodaFlavor.CreamSoda;
            }
        }

        private void OrangeSodaButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda data)
            {
                data.Flavor = CowboyCafe.Data.SodaFlavor.OrangeSoda;
            }
        }

        private void SarsparillaButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda data)
            {
                data.Flavor = CowboyCafe.Data.SodaFlavor.Sarsparilla;
            }
        }

        private void BirchBeerButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda data)
            {
                data.Flavor = CowboyCafe.Data.SodaFlavor.BirchBeer;
            }
        }

        private void RootBeerButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda data)
            {
                data.Flavor = CowboyCafe.Data.SodaFlavor.RootBeer;
            }
        }

        private void IceButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda data)
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

        private void SmallButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda data)
            {
                data.Size = CowboyCafe.Data.Size.Small;
            }
        }

        private void MediumButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda data)
            {
                data.Size = CowboyCafe.Data.Size.Medium;
            }
        }

        private void LargeButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda data)
            {
                data.Size = CowboyCafe.Data.Size.Large;
            }
        }
    }
}
