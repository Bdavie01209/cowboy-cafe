/*

* Author:blake davies


* Class name: Order.cs

* Purpose: To create the order Class

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {

        private static uint LastOrderNumber;

        public event PropertyChangedEventHandler PropertyChanged;

        public uint OrderNumber { get; private set; }

        public Order()
        {
            LastOrderNumber += 1;
            OrderNumber = LastOrderNumber + 1;
        }

        public double Subtotal { get; private set; } = 0;

        private List<IOrderItem> items = new List<IOrderItem>();

        public IEnumerable<IOrderItem> Items => items.ToArray();

        public void Add(IOrderItem itemtoAdd)
        {
            items.Add(itemtoAdd);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            Subtotal += itemtoAdd.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }


        public void Remove(IOrderItem itemToRemove)
        {
            if (items.Contains(itemToRemove))
            {
                items.Remove(itemToRemove);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
                Subtotal -= itemToRemove.Price;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
        }


    }
}
