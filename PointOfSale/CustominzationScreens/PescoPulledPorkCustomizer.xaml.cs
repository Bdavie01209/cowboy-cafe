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
    /// Interaction logic for PescoPulledPorkCustomizer.xaml
    /// </summary>
    public partial class PescoPulledPorkCustomizer : UserControl
    {
        public PescoPulledPorkCustomizer()
        {
            InitializeComponent();
        }

        private void ToggleBreadButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is PecosPulledPork data)
            {
                if (data.Bread)
                {
                    data.Bread = false;
                }
                else
                {
                    data.Bread = true;
                }
            }
        }

        private void TogglePickleButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is PecosPulledPork data)
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
    }
}
