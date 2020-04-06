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

        private double total;

        private double currSum;

        public CashDrawerPayment(double t)
        {
            InitializeComponent();
            total = Math.Round(t, 2);
            currSum = 0;
            TotalTextBox.Text = String.Format("Total: {0:C2}", total);
        }

        private void PennyButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CashDrawer cd)
            {
                currSum += .01;
                cd.AddCoin(Coins.Penny, 1);
                update();
            }
        }

        private void nickleButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CashDrawer cd)
            {
                currSum += .05;
                cd.AddCoin(Coins.Nickel, 1);
                update();
            }
        }

        private void DimeButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CashDrawer cd)
            {
                currSum += .1;
                cd.AddCoin(Coins.Dime, 1);
                update();
            }
        }

        private void QuarterButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CashDrawer cd)
            {
                currSum += .25;
                cd.AddCoin(Coins.Quarter, 1);
                update();
            }
        }

        private void DollarCoinButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CashDrawer cd)
            {
                currSum += 1;
                cd.AddCoin(Coins.Dollar, 1);
                update();
            }
        }

        private void HalfDollarButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CashDrawer cd)
            {
                currSum += .5;
                cd.AddCoin(Coins.HalfDollar, 1);
                update();
            }
        }

        private void DollarButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CashDrawer cd)
            {
                currSum += 1;
                cd.AddBill(Bills.One , 1);
                update();
            }
        }

        private void TwoDollarButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CashDrawer cd)
            {
                currSum += 2;
                cd.AddBill(Bills.Two, 1);
                update();
            }
        }

        private void FiveDollarButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CashDrawer cd)
            {
                currSum += 5;
                cd.AddBill(Bills.Five, 1);
                update();
            }
        }

        private void TenDollarButon_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CashDrawer cd)
            {
                currSum += 10;
                cd.AddBill(Bills.Ten, 1);
                update();
            }
        }

        private void TwentyDollarButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CashDrawer cd)
            {
                currSum += 20;
                cd.AddBill(Bills.Twenty, 1);
                update();
            }
        }

        private void FiftyDollarButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CashDrawer cd)
            {
                currSum += 50;
                cd.AddBill(Bills.Fifty, 1);
                update();
            }
        }

        private void HundredDollarButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CashDrawer cd)
            {
                currSum += 100;
                cd.AddBill(Bills.Hundred, 1);
                update();
            }
        }

        private void update()
        {
            sumTextBox.Text = string.Format("Payed So far \n {0:C2}", currSum);
        }

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
                    if (Math.Round(currSum,2) - total != 0)
                    {
                        MessageBox.Show("Error Creating Cash Back");
                        currSum = total + change;
                        undo(cashback);
                    }
                    else
                    {
                        StringBuilder changeTogive = new StringBuilder();
                        changeTogive.AppendLine(cashback[0] + " Hundreds");
                        changeTogive.AppendLine(cashback[1] + " Fifties");
                        changeTogive.AppendLine(cashback[2] + " Twenties");
                        changeTogive.AppendLine(cashback[3] + " Tens");
                        changeTogive.AppendLine(cashback[4] + " Fives");
                        changeTogive.AppendLine(cashback[5] + " Twos");
                        changeTogive.AppendLine(cashback[6] + " Dollar Bills");
                        changeTogive.AppendLine(cashback[7] + " Dollar Coins");
                        changeTogive.AppendLine(cashback[8] + " Half dollars");
                        changeTogive.AppendLine(cashback[9] + " Quarters");
                        changeTogive.AppendLine(cashback[10] + " Dimes");
                        changeTogive.AppendLine(cashback[11] + " Nickles");
                        changeTogive.AppendLine(cashback[12] + " Pennies");

                        MessageBox.Show(changeTogive.ToString());
                        MainWindow mainwindow = this.FindAncestor<MainWindow>();
                        mainwindow.PrintReceiptcash(paid, change);
                        mainwindow.SwapScreenBack();
                    }

                }
            }
        }

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
