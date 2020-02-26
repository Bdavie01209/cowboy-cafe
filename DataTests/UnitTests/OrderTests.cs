/*

* Author:Blake davies

* Class name: Ordertests.cs

* Purpose: To test the order class

*/
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;


namespace CowboyCafe.DataTests
{
    public class OrderTests
    {
        public class MockOrderItem : IOrderItem
        {

            public double Price { get; set; }

            public List<string> SpecialInstructions { get; set; }

        }



        [Fact]
        public void ShouldBeAbleToAddItems()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            Assert.Contains(item, order.Items);
        }

        [Fact]
        public void ShouldBeAbleToRemoveItems()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            order.Remove(item);
            Assert.DoesNotContain(item, order.Items);
        }

        [Fact]
        public void ShouldBeAbleToGetTheEnumerationOfTheItems()
        {
            var order = new Order();
            var item0 = new MockOrderItem();
            var item1 = new MockOrderItem();
            var item2 = new MockOrderItem();
            order.Add(item0);
            order.Add(item1);
            order.Add(item2);
            Assert.Collection(order.Items,
                item => Assert.Equal(item0, item),
                item => Assert.Equal(item1, item),
                item => Assert.Equal(item2, item));
        }

        [Theory]
        [InlineData(new double[] {1.1, 2, .3})]
        [InlineData(new double[] { 0,0,0})]
        [InlineData(new double[] { 100.56, 200})]
        [InlineData(new double[] { })]
        [InlineData(new double[] { -20.12})]
        [InlineData(new double[] {4.40, 12.65, -8 })]
        [InlineData(new double[] { 3.142592634123})]
        [InlineData(new double[] { double.NaN})]
        public void SubtotalShouldMatchSumOfItemPrices(double[] prices)
        {
            var order = new Order();
            double total = 0;

            foreach(double price in prices)
            {
                total += price;
                order.Add(new MockOrderItem()
                {
                    Price = price
                });
            }

            Assert.Equal(total, order.Subtotal);





        }

        [Theory]
        [InlineData("Subtotal")]
        [InlineData("Items")]
        public void AddingItemShouldTriggerPropertyChanged(string PropertyName)
        {
            var order = new Order();
            var item = new MockOrderItem();
            Assert.PropertyChanged(order, PropertyName, () =>
            {
                order.Add(item);
            });
        }

        [Theory]
        [InlineData("Subtotal")]
        [InlineData("Items")]
        public void RemovingItemShouldTriggerPropertyChanged(string PropertyName)
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            Assert.PropertyChanged(order, PropertyName, () =>
            {
                order.Remove(item);
            });
        }

        [Fact]
        public void OrderNumbersShouldNotBeSame()
        {
            var order0 = new Order();
            var order1 = new Order();

            Assert.NotEqual(order0.OrderNumber, order1.OrderNumber);


        }


    }
}
