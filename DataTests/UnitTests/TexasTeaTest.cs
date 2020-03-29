using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class TexasTeaTest
    {
        [Fact]
        public void ShouldBeIcedByDefault()
        {
            var tea = new TexasTea();
            Assert.True(tea.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            var tea = new TexasTea();
            tea.Ice = false;
            Assert.False(tea.Ice);
            tea.Ice = true;
            Assert.True(tea.Ice);
        }

        [Fact]
        public void ShouldBeSweetByDefault()
        {
            var tea = new TexasTea();
            Assert.True(tea.Sweet);
        }

        [Fact]
        public void ShouldBeAbleToSetSweetness()
        {
            var tea = new TexasTea();
            tea.Sweet = false;
            Assert.False(tea.Sweet);
            tea.Sweet = true;
            Assert.True(tea.Sweet);
        }

        [Fact]
        public void ShouldNotHaveLemonByDefault()
        {
            var tea = new TexasTea();
            Assert.False(tea.Lemon);
        }

        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            var tea = new TexasTea();
            tea.Lemon = true;
            Assert.True(tea.Lemon);
            tea.Lemon = false;
            Assert.False(tea.Lemon);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var tea = new TexasTea();
            Assert.Equal(Size.Small, tea.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var tea = new TexasTea();
            tea.Size = Size.Large;
            Assert.Equal(Size.Large, tea.Size);
            tea.Size = Size.Medium;
            Assert.Equal(Size.Medium, tea.Size);
            tea.Size = Size.Small;
            Assert.Equal(Size.Small, tea.Size);
        }

        [Theory]
        [InlineData(Size.Small, 1.00)]
        [InlineData(Size.Medium, 1.50)]
        [InlineData(Size.Large, 2.00)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var tea = new TexasTea()
            {
                Size = size
            };
            Assert.Equal(price, tea.Price);
        }

        [Theory]
        [InlineData(Size.Small, true, 10)]
        [InlineData(Size.Medium, true, 22)]
        [InlineData(Size.Large, true, 36)]
        [InlineData(Size.Small, false, 5)]
        [InlineData(Size.Medium, false, 11)]
        [InlineData(Size.Large, false, 18)]
        public void ShouldHaveCorrectCaloriesForSizeAndSweetness(Size size, bool sweet, uint calories)
        {
            var tea = new TexasTea()
            {
                Size = size,
                Sweet = sweet
            };
            Assert.Equal(calories, tea.Calories);
        }

        [Theory]
        [InlineData(false, false)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(true, true)]
        public void ShouldHaveCorrectSpecialInstructionsForIceAndLemon(bool ice, bool lemon)
        {
            var tea = new TexasTea()
            {
                Ice = ice,
                Lemon = lemon,
            };
            if (!ice) Assert.Contains("Hold Ice", tea.SpecialInstructions);
            if (lemon) Assert.Contains("Add Lemon", tea.SpecialInstructions);
            if (ice && !lemon) Assert.Empty(tea.SpecialInstructions);
            if (ice && lemon || !ice && !lemon) Assert.Single(tea.SpecialInstructions);
            if (!ice && lemon) Assert.Equal(2, tea.SpecialInstructions.Count);
        }

        // test1: TexasTea should implement the inotifypropertychangedinterface
        [Fact]
        public void TexasTeaShouldImplentInotifyPropertyChanged()
        {
            var TexasTea = new TexasTea();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(TexasTea);
        }


        // test2: chaning the "Ice" property should invoke propertychanged for "Ice"
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForIce()
        {
            var TexasTea = new TexasTea();
            Assert.PropertyChanged(TexasTea, "Ice", () => {
                TexasTea.Ice = false;
            });
        }

        // test3: chaning the "Ice" property should invoke propertychanged for "SpecialInstrcutions"
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var TexasTea = new TexasTea();
            Assert.PropertyChanged(TexasTea, "SpecialInstrcutions", () => {
                TexasTea.Ice = false;
            });
        }
        // test4: chaning the "Size" property should invoke propertychanged for "Size"
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSize()
        {
            var TexasTea = new TexasTea();
            Assert.PropertyChanged(TexasTea, "Size", () => {
                TexasTea.Size = Size.Large;
            });
        }

        // test5: chaning the "Size" property should invoke propertychanged for "Price"
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var TexasTea = new TexasTea();
            Assert.PropertyChanged(TexasTea, "Price", () => {
                TexasTea.Size = Size.Large;
            });
        }
        // test6: chaning the "Size" property should invoke propertychanged for "Calories"
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForCalories()
        {
            var TexasTea = new TexasTea();
            Assert.PropertyChanged(TexasTea, "Calories", () => {
                TexasTea.Size = Size.Large;
            });
        }



        // test: changing the "Lemon" property should invoke propertychanged for "Lemon"
        [Fact]
        public void ChangingLemonPropertyShouldInvokePropertyChangedForLemon()
        {
            var TexasTea = new TexasTea();
            Assert.PropertyChanged(TexasTea, "Lemon", () => {
                TexasTea.Lemon = false;
            });
        }


        //test: Changing the "Lemon" Property should invoke the property Changed for "SpecialInstrcutions"
        [Fact]
        public void ChangingLemonPropertyShouldInvokePropertyChangedForSpecialInstrcutions()
        {
            var TexasTea = new TexasTea();
            Assert.PropertyChanged(TexasTea, "SpecialInstrcutions", () => {
                TexasTea.Lemon = false;
            });
        }
        //test: Changing the "sweet" Property should invoke the property Changed for "sweet"
        [Fact]
        public void ChangingsweetPropertyShouldInvokePropertyChangedFosweet()
        {
            var TexasTea = new TexasTea();
            Assert.PropertyChanged(TexasTea, "SpecialInstrcutions", () => {
                TexasTea.Sweet = false;
            });
        }










    }
}
