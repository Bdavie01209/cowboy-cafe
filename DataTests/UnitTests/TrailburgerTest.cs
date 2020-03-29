using System;
using System.Collections.Generic;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class TrailBurgerTest
    {
        [Fact]
        public void DefaultPriceShouldBeCorrect()
        {
            var burger = new TrailBurger();
            Assert.Equal(4.50, burger.Price);
        }

        [Fact]
        public void DefaultCaloriesShouldBeCorrect()
        {
            var burger = new TrailBurger();
            Assert.Equal<uint>(288, burger.Calories);
        }

        [Fact]
        public void DefaultSpecialInstructionsShouldBeEmpty()
        {
            var burger = new TrailBurger();
            Assert.Empty(burger.SpecialInstructions);
        }

        [Fact]
        public void HoldingBunShouldAddInstruction()
        {
            var burger = new TrailBurger();
            burger.Bun = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold bun", instruction);
            });
        }

        [Fact]
        public void HoldingKetchupShouldAddInstruction()
        {
            var burger = new TrailBurger();
            burger.Ketchup = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold ketchup", instruction);
            });
        }

        [Fact]
        public void HoldingMustardShouldAddInstruction()
        {
            var burger = new TrailBurger();
            burger.Mustard = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold mustard", instruction);
            });
        }

        [Fact]
        public void HoldingPickleShouldAddInstruction()
        {
            var burger = new TrailBurger();
            burger.Pickle = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold pickle", instruction);
            });
        }

        [Fact]
        public void HoldingCheeseShouldAddInstruction()
        {
            var burger = new TrailBurger();
            burger.Cheese = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold cheese", instruction);
            });
        }

        [Fact]
        public void HoldingKetchupAndMustardShouldAddTwoInstructions()
        {
            var burger = new TrailBurger();
            burger.Ketchup = false;
            burger.Mustard = false;
            Assert.Contains("hold ketchup", burger.SpecialInstructions);
            Assert.Contains("hold mustard", burger.SpecialInstructions);
        }

        [Fact]
        public void HoldingBunCheeseAndPickleShouldAddThreeInstructions()
        {
            var burger = new TrailBurger();
            burger.Bun = false;
            burger.Cheese = false;
            burger.Pickle = false;
            Assert.Contains("hold bun", burger.SpecialInstructions);
            Assert.Contains("hold cheese", burger.SpecialInstructions);
            Assert.Contains("hold pickle", burger.SpecialInstructions);
        }

        // test1: TrailBurger should implement the inotifypropertychangedinterface
        [Fact]
        public void TrailBurgerShouldImplentInotifyPropertyChanged()
        {
            var burger = new TrailBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(burger);
        }


        //test: Changing the "Bun" Property should invoke the property Changed for "Bun"
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForBun()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "Bun", () => {
                burger.Bun = false;
            });
        }
        //test: Changing the "Bun" Property should invoke the property Changed for "SpecialInstructions"
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () => {
                burger.Bun = false;
            });
        }

        //test: Changing the "Ketchup" Property should invoke the property Changed for "Ketchup"
        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForKetchup()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "Ketchup", () => {
                burger.Ketchup = false;
            });
        }
        //test: Changing the "Ketchup" Property should invoke the property Changed for "SpecialInstructions"
        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () => {
                burger.Ketchup = false;
            });
        }

        //test: Changing the "Mustard" Property should invoke the property Changed for "Mustard"
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForMustard()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "Mustard", () => {
                burger.Mustard = false;
            });
        }
        //test: Changing the "Mustard" Property should invoke the property Changed for "SpecialInstructions"
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () => {
                burger.Mustard = false;
            });
        }

        //test: Changing the "Pickle" Property should invoke the property Changed for "Pickle"
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "Pickle", () => {
                burger.Pickle = false;
            });
        }
        //test: Changing the "Pickle" Property should invoke the property Changed for "SpecialInstructions"
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () => {
                burger.Pickle = false;
            });
        }

        //test: Changing the "Cheese" Property should invoke the property Changed for "Cheese"
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForCheese()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "Cheese", () => {
                burger.Cheese = false;
            });
        }
        //test: Changing the "Cheese" Property should invoke the property Changed for "SpecialInstructions"
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () => {
                burger.Cheese = false;
            });
        }

    }


}
