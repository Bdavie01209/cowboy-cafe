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

    }
}
