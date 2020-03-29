using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class WaterTest
    {
        [Fact]
        public void ShouldBeIcedByDefault()
        {
            var water = new Water();
            Assert.True(water.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            var water = new Water();
            water.Ice = false;
            Assert.False(water.Ice);
            water.Ice = true;
            Assert.True(water.Ice);
        }

        [Fact]
        public void ShouldNotHaveLemonByDefault()
        {
            var water = new Water();
            Assert.False(water.Lemon);
        }

        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            var water = new Water();
            water.Lemon = true;
            Assert.True(water.Lemon);
            water.Lemon = false;
            Assert.False(water.Lemon);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var water = new Water();
            Assert.Equal(Size.Small, water.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var water = new Water();
            water.Size = Size.Large;
            Assert.Equal(Size.Large, water.Size);
            water.Size = Size.Medium;
            Assert.Equal(Size.Medium, water.Size);
            water.Size = Size.Small;
            Assert.Equal(Size.Small, water.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.12)]
        [InlineData(Size.Medium, 0.12)]
        [InlineData(Size.Large, 0.12)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var water = new Water()
            {
                Size = size
            };
            Assert.Equal(price, water.Price);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint calories)
        {
            var water = new Water()
            {
                Size = size
            };
            Assert.Equal(calories, water.Calories);
        }

        [Theory]
        [InlineData(false, false)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(true, true)]
        public void ShouldHaveCorrectSpecialInstructionsForIceAndLemon(bool ice, bool lemon)
        {
            var water = new Water()
            {
                Ice = ice,
                Lemon = lemon,
            };
            if (!ice) Assert.Contains("Hold Ice", water.SpecialInstructions);
            if (lemon) Assert.Contains("Add Lemon", water.SpecialInstructions);
            if (ice && !lemon) Assert.Empty(water.SpecialInstructions);
            if (ice && lemon || !ice && !lemon) Assert.Single(water.SpecialInstructions);
            if (!ice && lemon) Assert.Equal(2, water.SpecialInstructions.Count);
        }


        // test1: water should implement the inotifypropertychangedinterface
        [Fact]
        public void WaterShouldImplentInotifyPropertyChanged()
        {
            var Water = new Water();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(Water);
        }


        // test2: chaning the "Ice" property should invoke propertychanged for "Ice"
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForIce()
        {
            var Water = new Water();
            Assert.PropertyChanged(Water, "Ice", () => {
                Water.Ice = false;
            });
        }

        // test3: chaning the "Ice" property should invoke propertychanged for "SpecialInstrcutions"
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var Water = new Water();
            Assert.PropertyChanged(Water, "SpecialInstrcutions", () => {
                Water.Ice = false;
            });
        }
        // test4: chaning the "Size" property should invoke propertychanged for "Size"
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSize()
        {
            var Water = new Water();
            Assert.PropertyChanged(Water, "Size", () => {
                Water.Size = Size.Large;
            });
        }

        // test5: chaning the "Size" property should invoke propertychanged for "Price"
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var Water = new Water();
            Assert.PropertyChanged(Water, "Price", () => {
                Water.Size = Size.Large;
            });
        }
        // test6: chaning the "Size" property should invoke propertychanged for "Calories"
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForCalories()
        {
            var Water = new Water();
            Assert.PropertyChanged(Water, "Calories", () => {
                Water.Size = Size.Large;
            });
        }



        // test5: changing the "Lemon" property should invoke propertychanged for "Lemon"
        [Fact]
        public void ChangingLemonPropertyShouldInvokePropertyChangedForLemon()
        {
            var Water = new Water();
            Assert.PropertyChanged(Water, "Lemon", () => {
                Water.Lemon = false;
            });
        }




        //test: Changing the "Lemon" Property should invoke the property Changed for "TortillaStrips"
        [Fact]
        public void ChangingLemonPropertyShouldInvokePropertyChangedForSpecialInstrcutions()
        {
            var Water = new Water();
            Assert.PropertyChanged(Water, "SpecialInstrcutions", () => {
                Water.Lemon = false;
            });
        }


    }
}

