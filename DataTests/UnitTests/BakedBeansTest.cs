using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class BakedBeansTest
    {
        //should cost 1.59 to begin with
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            BakedBeans beans = new BakedBeans();
            Assert.Equal(1.59, beans.Price);
        }

        //should have correct caloires by default
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            BakedBeans beans = new BakedBeans();
            Assert.Equal<uint>(312, beans.Calories);
        }

        //should have small as default size
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            BakedBeans beans = new BakedBeans();
            Assert.Equal<Size>(Size.Small, beans.Size);
        }

        // price should be depended on size
        [Theory]
        [InlineData(Size.Small, 1.59)]
        [InlineData(Size.Medium, 1.79)]
        [InlineData(Size.Large, 1.99)]
        public void ShouldUseCorrectPriceForSize(Size size, double price)
        {
            BakedBeans beans = new BakedBeans();
            beans.Size = Size.Medium;
            beans.Size = size;
            Assert.Equal(price, beans.Price);
        }

        /// <summary>
        /// caloires should be dependent on size
        /// </summary>
        /// <param name="size"></param>
        /// <param name="calories"></param>
        [Theory]
        [InlineData(Size.Small, 312)]
        [InlineData(Size.Medium, 378)]
        [InlineData(Size.Large, 410)]
        public void ShouldUseCorrectCaloriesForSize(Size size, uint calories)
        {
            BakedBeans beans = new BakedBeans();
            beans.Size = Size.Medium;
            beans.Size = size;
            Assert.Equal<uint>(calories, beans.Calories);
        }



        // BakedBeans should implement the inotifypropertychangedinterface
        [Fact]
        public void BakedBensShouldImpliemntInotifyPropertyChanged()
        {
            var bakedBeans = new BakedBeans();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(bakedBeans);
        }



        [Fact]
        public void ChaningSizePropertyshouldNotifySize()
        {
            var bakedBeans = new BakedBeans();
            Assert.PropertyChanged(bakedBeans, "Size", () => {
                bakedBeans.Size = Size.Large;
            });
        }
        
        
        [Fact]
        public void ChaningSizePropertyshouldNotifyprice()
        {
            var bakedBeans = new BakedBeans();
            Assert.PropertyChanged(bakedBeans, "Price", () => {
                bakedBeans.Size = Size.Large;
            });
        }
        [Fact]
        public void ChaningSizePropertyshouldNotifyCalories()
        {
            var bakedBeans = new BakedBeans();
            Assert.PropertyChanged(bakedBeans, "Calories", () => {
                bakedBeans.Size = Size.Large;
            });
        }





    }
}
