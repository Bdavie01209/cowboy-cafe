using CashRegister;
using CowboyCafe.Data;
using PointOfSale.ExtensionMethods;
using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {

        private double total;
        private Order order;

        public TransactionControl(Order order)
        {
            InitializeComponent();
            DataContext = order;
            this.order = order;
            subtotalBox.Text = "" + order.Subtotal;
            total = Math.Round(order.Subtotal * 1.16, 2);
            TotalBox.Text = String.Format("{0:0.00}", total);
        }

        private void CancleButton_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = this.FindAncestor<MainWindow>();
            mainwindow.SwapScreenBack();
        }

        private void CreditButton_Click(object sender, RoutedEventArgs e)
        {
            CardTerminal cardTerminal = new CardTerminal();

            var results = cardTerminal.ProcessTransaction(total);


            switch (results)
            {
                case ResultCode.Success:
                    var mainwindow = this.FindAncestor<MainWindow>();
                    mainwindow.PrintReceiptCredit();
                    mainwindow.SwapScreenBack();
                    break;
                default:
                    MessageBox.Show("Error Reading card: " + results);
                    break;
            }
        }




        private void CashButton_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = this.FindAncestor<MainWindow>();
            CashDrawerPayment cashdrawerscreen = new CashDrawerPayment(total);
            cashdrawerscreen.DataContext = mainwindow.cashdrawer;
            mainwindow.SwapScreen(cashdrawerscreen);
        }
    }











}
