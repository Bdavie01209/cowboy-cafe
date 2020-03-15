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
    /// Interaction logic for TexasTeaCustomizer.xaml
    /// </summary>
    public partial class TexasTeaCustomizer : UserControl
    {
        public TexasTeaCustomizer()
        {
            InitializeComponent();
        }

        private void SmallButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is TexasTea data)
            {
                data.Size = CowboyCafe.Data.Size.Small;
            }
        }

        private void MediumButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is TexasTea data)
            {
                data.Size = CowboyCafe.Data.Size.Medium;
            }
        }

        private void LargeButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is TexasTea data)
            {
                data.Size = CowboyCafe.Data.Size.Large;
            }
        }

        private void IceButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is TexasTea data)
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

        private void LemonButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is TexasTea data)
            {
                if (data.Lemon)
                {
                    data.Lemon = false;
                }
                else
                {
                    data.Lemon = true;
                }
            }
        }

        private void SweetButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is TexasTea data)
            {
                if (data.Sweet)
                {
                    data.Sweet = false;
                }
                else
                {
                    data.Sweet = true;
                }
            }
        }
    }
}

