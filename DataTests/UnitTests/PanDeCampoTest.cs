using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class PanDeCampoTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            PanDeCampo pdc = new PanDeCampo();
            Assert.Equal(1.59, pdc.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            PanDeCampo pdc = new PanDeCampo();
            Assert.Equal<uint>(227, pdc.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            PanDeCampo pdc = new PanDeCampo();
            Assert.Equal<Size>(Size.Small, pdc.Size);
        }

        [Theory]
        [InlineData(Size.Small, 1.59)]
        [InlineData(Size.Medium, 1.79)]
        [InlineData(Size.Large, 1.99)]
        public void ShouldUseCorrectPriceForSize(Size size, double price)
        {
            PanDeCampo pdc = new PanDeCampo();
            pdc.Size = Size.Medium;
            pdc.Size = size;
            Assert.Equal(price, pdc.Price);
        }

        [Theory]
        [InlineData(Size.Small, 227)]
        [InlineData(Size.Medium, 269)]
        [InlineData(Size.Large, 367)]
        public void ShouldUseCorrectCaloriesForSize(Size size, uint calories)
        {
            PanDeCampo pdc = new PanDeCampo();
            pdc.Size = Size.Medium;
            pdc.Size = size;
            Assert.Equal<uint>(calories, pdc.Calories);
        }

        // PanDeCampo should implement the inotifypropertychangedinterface
        [Fact]
        public void PanDeCampoShouldImpliemntInotifyPropertyChanged()
        {
            var panDeCampo = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(panDeCampo);
        }



        [Fact]
        public void ChaningSizePropertyshouldNotifySize()
        {
            var panDeCampo = new PanDeCampo();
            Assert.PropertyChanged(panDeCampo, "Size", () => {
                panDeCampo.Size = Size.Large;
            });
        }


        [Fact]
        public void ChaningSizePropertyshouldNotifyprice()
        {
            var panDeCampo = new PanDeCampo();
            Assert.PropertyChanged(panDeCampo, "Price", () => {
                panDeCampo.Size = Size.Large;
            });
        }
        [Fact]
        public void ChaningSizePropertyshouldNotifyCalories()
        {
            var panDeCampo = new PanDeCampo();
            Assert.PropertyChanged(panDeCampo, "Calories", () => {
                panDeCampo.Size = Size.Large;
            });
        }










    }
}
