using CashRegister;
using CowboyCafe.Data;
using PointOfSale.ExtensionMethods;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashDrawerPayment.xaml
    /// </summary>
    public partial class CashDrawerPayment : UserControl
    {
        /// <summary>
        /// total to reach
        /// </summary>
        private double total;

        /// <summary>
        /// how much user has put in
        /// </summary>
        private double currSum;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="t">total cost</param>
        public CashDrawerPayment(double t)
        {
            InitializeComponent();
            total = Math.Round(t, 2);
            currSum = 0;
            TotalTextBox.Text = String.Format("Total: {0:C2}", total);
        }

        /// <summary>
        /// button for when penny is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PennyButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CashDrawer cd)
            {
                currSum += .01;
                cd.AddCoin(Coins.Penny, 1);
                update();
            }
        }
        /// <summary>
        /// button for when nickle is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nickleButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CashDrawer cd)
            {
                currSum += .05;
                cd.AddCoin(Coins.Nickel, 1);
                update();
            }
        }

        /// <summary>
        /// button for when dime is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DimeButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CashDrawer cd)
            {
                currSum += .1;
                cd.AddCoin(Coins.Dime, 1);
                update();
            }
        }

        /// <summary>
        /// button for when quarter is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuarterButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CashDrawer cd)
            {
                currSum += .25;
                cd.AddCoin(Coins.Quarter, 1);
                update();
            }
        }

        /// <summary>
        /// button for when dollar coin is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DollarCoinButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CashDrawer cd)
            {
                currSum += 1;
                cd.AddCoin(Coins.Dollar, 1);
                update();
            }
        }

        /// <summary>
        /// button for when half dollar button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HalfDollarButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CashDrawer cd)
            {
                currSum += .5;
                cd.AddCoin(Coins.HalfDollar, 1);
                update();
            }
        }

        /// <summary>
        /// button for when dollar bill is prseed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DollarButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CashDrawer cd)
            {
                currSum += 1;
                cd.AddBill(Bills.One , 1);
                update();
            }
        }

        /// <summary>
        /// button for when two dollar button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TwoDollarButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CashDrawer cd)
            {
                currSum += 2;
                cd.AddBill(Bills.Two, 1);
                update();
            }
        }

        /// <summary>
        /// button for when fivedollar button is prssed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FiveDollarButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CashDrawer cd)
            {
                currSum += 5;
                cd.AddBill(Bills.Five, 1);
                update();
            }
        }

        /// <summary>
        /// button for when ten dollar button is preeseds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TenDollarButon_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CashDrawer cd)
            {
                currSum += 10;
                cd.AddBill(Bills.Ten, 1);
                update();
            }
        }

        /// <summary>
        /// handler for when twentydollarbutton is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TwentyDollarButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CashDrawer cd)
            {
                currSum += 20;
                cd.AddBill(Bills.Twenty, 1);
                update();
            }
        }

        /// <summary>
        /// handler for when fiftydollarbutton is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FiftyDollarButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CashDrawer cd)
            {
                currSum += 50;
                cd.AddBill(Bills.Fifty, 1);
                update();
            }
        }

        /// <summary>
        /// handler for when hundreddollarbutton is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HundredDollarButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CashDrawer cd)
            {
                currSum += 100;
                cd.AddBill(Bills.Hundred, 1);
                update();
            }
        }

        /// <summary>
        /// updates the payed so far button
        /// </summary>
        private void update()
        {
            sumTextBox.Text = string.Format("Payed So far \n {0:C2}", currSum);
        }

        /// <summary>
        /// handler for when the finalize button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(DataContext is CashDrawer cd)
            {

                List<int> cashback = new List<int>();
                if (currSum < total)
                {
                    MessageBox.Show("Not Enough Payed");
                }
                if (currSum >= total)
                {
                    double change = currSum - total;
                    double paid = currSum;
                    cashback.Add(FindChangeDollar(Bills.Hundred, cd.Hundreds, 100));
                    cashback.Add(FindChangeDollar(Bills.Fifty, cd.Fifties, 50));
                    cashback.Add(FindChangeDollar(Bills.Twenty, cd.Twenties, 20));
                    cashback.Add(FindChangeDollar(Bills.Ten, cd.Tens, 10));
                    cashback.Add(FindChangeDollar(Bills.Five, cd.Fives, 5));
                    cashback.Add(FindChangeDollar(Bills.Two, cd.Twos, 2));
                    cashback.Add(FindChangeDollar(Bills.One, cd.Ones, 1));
                    cashback.Add(FindChangeCoin(Coins.Dollar, cd.Dollars, 1));
                    cashback.Add(FindChangeCoin(Coins.HalfDollar, cd.HalfDollars, .5));
                    cashback.Add(FindChangeCoin(Coins.Quarter, cd.Quarters, .25));
                    cashback.Add(FindChangeCoin(Coins.Dime, cd.Dimes, .1));
                    cashback.Add(FindChangeCoin(Coins.Nickel, cd.Nickels, .05));
                    cashback.Add(FindChangeCoin(Coins.Penny, cd.Pennies, .01));
                    if (Math.Round(currSum,2) - total !< 0)
                    {
                        MessageBox.Show("Error Creating Cash Back");
                        currSum = total + change;
                        undo(cashback);
                    }
                    else
                    {
                        StringBuilder changeTogive = new StringBuilder();
                        if(cashback[0] != 0) changeTogive.AppendLine(cashback[0] + " Hundreds");
                        if (cashback[1] != 0) changeTogive.AppendLine(cashback[1] + " Fifties");
                        if (cashback[2] != 0) changeTogive.AppendLine(cashback[2] + " Twenties");
                        if (cashback[3] != 0) changeTogive.AppendLine(cashback[3] + " Tens");
                        if (cashback[4] != 0) changeTogive.AppendLine(cashback[4] + " Fives");
                        if (cashback[5] != 0) changeTogive.AppendLine(cashback[5] + " Twos");
                        if (cashback[6] != 0) changeTogive.AppendLine(cashback[6] + " Dollar Bills");
                        if (cashback[7] != 0) changeTogive.AppendLine(cashback[7] + " Dollar Coins");
                        if (cashback[8] != 0) changeTogive.AppendLine(cashback[8] + " Half dollars");
                        if (cashback[9] != 0) changeTogive.AppendLine(cashback[9] + " Quarters");
                        if (cashback[10] != 0) changeTogive.AppendLine(cashback[10] + " Dimes");
                        if (cashback[11] != 0) changeTogive.AppendLine(cashback[11] + " Nickles");
                        if (cashback[12] != 0) changeTogive.AppendLine(cashback[12] + " Pennies");

                        MessageBox.Show(changeTogive.ToString());
                        MainWindow mainwindow = this.FindAncestor<MainWindow>();
                        mainwindow.PrintReceiptcash(paid, change);
                        mainwindow.SwapScreenBack();
                    }

                }
            }
        }

        /// <summary>
        /// buton to show cash drawer contents
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CashDrawerContents_Click(object sender, RoutedEventArgs e)
        {
            if(DataContext is CashDrawer cd)
            {
                List<string> listbox = new List<string>();
                listbox.Add("Pennies: " + cd.Pennies);
                listbox.Add("Nickles: " + cd.Nickels);
                listbox.Add("Dimes: " + cd.Dimes);
                listbox.Add("Quarters: " + cd.Quarters);
                listbox.Add("HalfDollars: " + cd.HalfDollars);
                listbox.Add("Dollarcoins: " + cd.Dollars);
                listbox.Add("Ones: " + cd.Ones);
                listbox.Add("Twos: " + cd.Twos);
                listbox.Add("Fives: " + cd.Fives);
                listbox.Add("Tens: " + cd.Tens);
                listbox.Add("Twenties: " + cd.Twenties);
                listbox.Add("Fifties: " + cd.Fifties);
                listbox.Add("Hundreds: " + cd.Hundreds);

                MoneyListBox.ItemsSource = listbox;
            }
        }

        /// <summary>
        /// finds the given change amount back for a certain dollar amount
        /// </summary>
        /// <param name="b">the dollar that is being removed</param>
        /// <param name="totalNum">the amount that the cash drawer has</param>
        /// <param name="valueofDenom">value of the the denom</param>
        /// <returns>amount of that dollar removed</returns>
        private int FindChangeDollar(Bills b, int totalNum, double valueofDenom)
        {
            int returnValue = -1;
            if (DataContext is CashDrawer cd)
            {
                returnValue = 0;
                while (currSum - total > valueofDenom && totalNum > 0)
                {
                    currSum -= valueofDenom;
                    returnValue += 1;
                    cd.RemoveBill(b, 1);
                    totalNum -= 1;
                }
            }
            return returnValue;
        }
        /// <summary>
        /// finds the given change amount back for a certain dollar amount
        /// </summary>
        /// <param name="b">the coin that is being removed</param>
        /// <param name="totalNum">the amount that the cash drawer has</param>
        /// <param name="valueofDenom">value of the the denom</param>
        /// <returns>amount of that coin removed</returns>
        private int FindChangeCoin(Coins c, int totalNum, double valueofDenom)
        {
            int returnValue = -1;
            if (DataContext is CashDrawer cd)
            {
                returnValue = 0;
                while (currSum - total > valueofDenom && totalNum > 0)
                {
                    currSum -= valueofDenom;
                    returnValue += 1;
                    cd.RemoveCoin(c, 1);
                    totalNum -= 1;
                }
            }
            return returnValue;
        }

        /// <summary>
        /// undos any change being removed
        /// </summary>
        /// <param name="c"></param>
        private void undo(List<int> c)
        {
            if(DataContext is CashDrawer cd)
            {
                cd.AddBill(Bills.Hundred, c[0]);
                cd.AddBill(Bills.Fifty, c[1]);
                cd.AddBill(Bills.Twenty, c[2]);
                cd.AddBill(Bills.Ten, c[3]);
                cd.AddBill(Bills.Five, c[4]);
                cd.AddBill(Bills.Two, c[5]);
                cd.AddBill(Bills.One, c[6]);
                cd.AddCoin(Coins.Dollar, c[7]);
                cd.AddCoin(Coins.HalfDollar, c[8]);
                cd.AddCoin(Coins.Quarter, c[9]);
                cd.AddCoin(Coins.Dime, c[10]);
                cd.AddCoin(Coins.Nickel, c[11]);
                cd.AddCoin(Coins.Penny, c[12]);
            }
        }



    }




}
