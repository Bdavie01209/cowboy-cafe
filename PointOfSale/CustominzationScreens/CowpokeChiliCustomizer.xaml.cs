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
    /// Interaction logic for CowpokeChiliCustomizer.xaml
    /// </summary>
    public partial class CowpokeChiliCustomizer : UserControl
    {
        public CowpokeChiliCustomizer()
        {
            InitializeComponent();
        }

        private void ToggleCheeseButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CowpokeChili data)
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

        private void ToggleGreenOnionButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CowpokeChili data)
            {
                if (data.GreenOnions)
                {
                    data.GreenOnions = false;
                }
                else
                {
                    data.GreenOnions = true;
                }
            }
        }

        private void ToggleSourCreamButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CowpokeChili data)
            {
                if (data.SourCream)
                {
                    data.SourCream = false;
                }
                else
                {
                    data.SourCream = true;
                }
            }
        }

        private void ToggleTortiaStripsButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CowpokeChili data)
            {
                if (data.TortillaStrips)
                {
                    data.TortillaStrips = false;
                }
                else
                {
                    data.TortillaStrips = true;
                }
            }
        }
    }
}
