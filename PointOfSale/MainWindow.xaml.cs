/*

* Author: Blake Davies

* File name: mainWindow.Xaml.cs

* Purpose:  to create the point of sale

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CashRegister;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// printer to print from
        /// </summary>
        private ReceiptPrinter printer = new ReceiptPrinter();
        /// <summary>
        /// cash drawer that keeps all data
        /// </summary>
        public CashDrawer cashdrawer;
        /// <summary>
        /// ordercontrol from most recent instance
        /// </summary>
        private OrderControl orderControl;

        public MainWindow()
        {
            InitializeComponent();
            cashdrawer = new CashDrawer();
            orderControl = new OrderControl();
            screenHousingmain.Child = orderControl;
        }

        /// <summary>
        /// swaps the screen of the main window
        /// </summary>
        /// <param name="element"></param>
        public void SwapScreen(FrameworkElement element)
        {
            screenHousingmain.Child = element;
        }
        /// <summary>
        /// returns to the previous order control
        /// </summary>
        public void SwapScreenBack()
        {
            screenHousingmain.Child = orderControl;
            orderControl.Reset();
        }

        /// <summary>
        /// pritns a given recipte 
        /// </summary>
        public void PrintReceiptCredit()
        {
            var o = (Order)orderControl.DataContext;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Number: " + o.OrderNumber);
            sb.AppendLine("Time: " + System.DateTime.Now);
            foreach (IOrderItem item in o.Items)
            {
                sb.AppendLine("" + item.ToString() + "  " + item.Price);
                foreach (string s in item.SpecialInstructions)
                {
                    sb.AppendLine(s);
                }
            }
            sb.AppendLine(string.Format("Subtotal: {0:c2}",o.Subtotal));
            sb.AppendLine(string.Format("Total: {0:c2}",o.Subtotal * 1.16));
            sb.AppendLine("Credit Used");

            printer.Print(sb.ToString());
        }
        /// <summary>
        /// prints a given recipt
        /// </summary>
        /// <param name="paid">amount user paid</param>
        /// <param name="change">amount user recived back</param>
        public void PrintReceiptcash(double paid, double change)
        {
            var o = (Order)orderControl.DataContext;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Number: " + o.OrderNumber);
            sb.AppendLine("Time: " + System.DateTime.Now);
            foreach (IOrderItem item in o.Items)
            {
                sb.AppendLine("" + item.ToString() + "  " + item.Price);
                foreach (string s in item.SpecialInstructions)
                {
                    sb.AppendLine(s);
                }
            }
            sb.AppendLine(string.Format("Subtotal: {0:c2}", o.Subtotal));
            sb.AppendLine(string.Format("Total: {0:c2}", o.Subtotal * 1.16));
            sb.AppendLine(string.Format("Paid: {0:c2}", paid));
            sb.AppendLine(string.Format("Change Back: {0:c2}", change));



            printer.Print(sb.ToString());
        }
    }
}
