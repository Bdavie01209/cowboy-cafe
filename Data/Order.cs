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
        /// <summary>
        /// static uint for what the order number previously was
        /// </summary>
        private static uint LastOrderNumber = 98;

        /// <summary>
        /// event to invoke whenever public property is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// public ordernumber accesor
        /// </summary>
        public uint OrderNumber { get; private set; }

        /// <summary>
        /// public constructor to incriment lastordernumber and generate new order
        /// </summary>
        public Order()
        {
            LastOrderNumber += 1;
            OrderNumber = LastOrderNumber + 1;
        }
        /// <summary>
        /// the cost of the order
        /// </summary>
        public double Subtotal 
        {
            get
            {
                double returnValue = 0;
                foreach (IOrderItem i in items)
                {
                    returnValue += i.Price;
                }
                return returnValue;
            }
        }

        /// <summary>
        /// list of all that the order contains
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// copy of the contents of the order
        /// </summary>
        public IEnumerable<IOrderItem> Items => items.ToArray();

        /// <summary>
        /// adding item to the order
        /// </summary>
        /// <param name="itemtoAdd">item that will be added</param>
        public void Add(IOrderItem itemtoAdd)
        {
            items.Add(itemtoAdd);
            //item.PropertyChanged += OnItemchanged;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        /// <summary>
        /// removing items from the order
        /// </summary>
        /// <param name="itemToRemove">item that will be removed</param>
        public void Remove(IOrderItem itemToRemove)
        {
            if (items.Contains(itemToRemove))
            {
                items.Remove(itemToRemove);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
        }

        private void OnItemchanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if (e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubTotal"));
            }
        }
    }
}
