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
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// when the mouse is pressed down on a text box this is the event that goes through checking what it is and changing the screen accordingly
        /// </summary>
        /// <param name="sender">textboxes containing the name of the items</param>
        /// <param name="e"></param>
        private void EditOrder(object sender, RoutedEventArgs e)
        {
            var tb = (TextBlock)e.OriginalSource;
            var dataCxtx = tb.DataContext;
            var ordercontrol = this.FindAncestor<OrderControl>();

            if (dataCxtx is Side s) { ordercontrol.SwapScreen(new SideCustomizer() { DataContext = s }); }

            else if (dataCxtx is AngryChicken a) { ordercontrol.SwapScreen(new AngryChickenCustomizer() { DataContext = a }); }
            
            else if (dataCxtx is CowboyCoffee cc) { ordercontrol.SwapScreen(new CowBoyCoffeeCustomizer() { DataContext = cc }); }
            
            else if (dataCxtx is CowpokeChili c) { ordercontrol.SwapScreen(new CowpokeChiliCustomizer() { DataContext = c }); }
            
            else if (dataCxtx is DakotaDoubleBurger db) { ordercontrol.SwapScreen(new DakotaDoubleBurgerCustomizer() { DataContext = db }); }
            
            else if (dataCxtx is JerkedSoda js) { ordercontrol.SwapScreen(new JerkedSodaCustomizer() { DataContext = js }); }

            else if (dataCxtx is PecosPulledPork ppp) { ordercontrol.SwapScreen(new PescoPulledPorkCustomizer() { DataContext = ppp }); }
            
            else if (dataCxtx is TexasTea tt) { ordercontrol.SwapScreen(new TexasTeaCustomizer() { DataContext = tt }); }
            
            else if (dataCxtx is TexasTripleBurger ttb) { ordercontrol.SwapScreen(new TexasTripleBurgerCustomizer() { DataContext = ttb }); }
            
            else if (dataCxtx is TrailBurger trb) { ordercontrol.SwapScreen(new TrailBurgerCustomizer() { DataContext = trb }); }
            
            else if (dataCxtx is Water w) { ordercontrol.SwapScreen(new WaterCustomizer() { DataContext = w }); }

            else
            {
                throw new NotImplementedException("UnknownOrder");
            }

        }

        /// <summary>
        /// when the x button next to an item is clicked it removes it
        /// </summary>
        /// <param name="sender">a button</param>
        /// <param name="e"></param>
        private void RemoveFromOrder(object sender, RoutedEventArgs e)
        {
            var button = (Button)e.OriginalSource;
            if (button.DataContext is IOrderItem data)
            {
                var ordercontrol = this.FindAncestor<OrderControl>();

                if (ordercontrol.DataContext is Order or)
                {
                    or.Remove(data);
                }
            }




        }
    }
}
