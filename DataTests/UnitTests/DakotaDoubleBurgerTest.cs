﻿using System;
using System.Collections.Generic;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class DakotaDoubleBurgerTest
    {
        [Fact]
        public void DefaultPriceShouldBeCorrect()
        {
            var burger = new DakotaDoubleBurger();
            Assert.Equal(5.20, burger.Price);
        }

        [Fact]
        public void DefaultCaloriesShouldBeCorrect()
        {
            var burger = new DakotaDoubleBurger();
            Assert.Equal<uint>(464, burger.Calories);
        }

        [Fact]
        public void DefaultSpecialInstructionsShouldBeEmpty()
        {
            var burger = new DakotaDoubleBurger();
            Assert.Empty(burger.SpecialInstructions);
        }

        [Fact]
        public void HoldingBunShouldAddInstruction()
        {
            var burger = new DakotaDoubleBurger();
            burger.Bun = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold bun", instruction);
            });
        }

        [Fact]
        public void HoldingKetchupShouldAddInstruction()
        {
            var burger = new DakotaDoubleBurger();
            burger.Ketchup = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold ketchup", instruction);
            });
        }

        [Fact]
        public void HoldingMustardShouldAddInstruction()
        {
            var burger = new DakotaDoubleBurger();
            burger.Mustard = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold mustard", instruction);
            });
        }

        [Fact]
        public void HoldingPickleShouldAddInstruction()
        {
            var burger = new DakotaDoubleBurger();
            burger.Pickle = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold pickle", instruction);
            });
        }

        [Fact]
        public void HoldingCheeseShouldAddInstruction()
        {
            var burger = new DakotaDoubleBurger();
            burger.Cheese = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold cheese", instruction);
            });
        }

        [Fact]
        public void HoldingMayoShouldAddInstruction()
        {
            var burger = new DakotaDoubleBurger();
            burger.Mayo = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold mayo", instruction);
            });
        }

        [Fact]
        public void HoldingLettuceShouldAddInstruction()
        {
            var burger = new DakotaDoubleBurger();
            burger.Lettuce = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold lettuce", instruction);
            });
        }

        [Fact]
        public void HoldingTomatoShouldAddInstruction()
        {
            var burger = new DakotaDoubleBurger();
            burger.Tomato = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold tomato", instruction);
            });
        }

        [Fact]
        public void HoldingKetchupAndMustardShouldAddTwoInstructions()
        {
            var burger = new DakotaDoubleBurger();
            burger.Ketchup = false;
            burger.Mustard = false;
            Assert.Contains("hold ketchup", burger.SpecialInstructions);
            Assert.Contains("hold mustard", burger.SpecialInstructions);
        }

        [Fact]
        public void HoldingBunCheeseAndPickleShouldAddThreeInstructions()
        {
            var burger = new DakotaDoubleBurger();
            burger.Bun = false;
            burger.Cheese = false;
            burger.Pickle = false;
            Assert.Contains("hold bun", burger.SpecialInstructions);
            Assert.Contains("hold cheese", burger.SpecialInstructions);
            Assert.Contains("hold pickle", burger.SpecialInstructions);
        }


        // test1: DakotaDoubleBurger should implement the inotifypropertychangedinterface
        [Fact]
        public void DakotaDoubleBurgerShouldImplentInotifyPropertyChanged()
        {
            var burger = new DakotaDoubleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(burger);
        }


        //test: Changing the "Bun" Property should invoke the property Changed for "Bun"
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForBun()
        {
            var burger = new DakotaDoubleBurger();
            Assert.PropertyChanged(burger, "Bun", () => {
                burger.Bun = false;
            });
        }
        //test: Changing the "Bun" Property should invoke the property Changed for "SpecialInstructions"
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new DakotaDoubleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () => {
                burger.Bun = false;
            });
        }

        //test: Changing the "Ketchup" Property should invoke the property Changed for "Ketchup"
        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForKetchup()
        {
            var burger = new DakotaDoubleBurger();
            Assert.PropertyChanged(burger, "Ketchup", () => {
                burger.Ketchup = false;
            });
        }
        //test: Changing the "Ketchup" Property should invoke the property Changed for "SpecialInstructions"
        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new DakotaDoubleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () => {
                burger.Ketchup = false;
            });
        }

        //test: Changing the "Mustard" Property should invoke the property Changed for "Mustard"
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForMustard()
        {
            var burger = new DakotaDoubleBurger();
            Assert.PropertyChanged(burger, "Mustard", () => {
                burger.Mustard = false;
            });
        }
        //test: Changing the "Mustard" Property should invoke the property Changed for "SpecialInstructions"
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new DakotaDoubleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () => {
                burger.Mustard = false;
            });
        }

        //test: Changing the "Pickle" Property should invoke the property Changed for "Pickle"
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var burger = new DakotaDoubleBurger();
            Assert.PropertyChanged(burger, "Pickle", () => {
                burger.Pickle = false;
            });
        }
        //test: Changing the "Pickle" Property should invoke the property Changed for "SpecialInstructions"
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new DakotaDoubleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () => {
                burger.Pickle = false;
            });
        }

        //test: Changing the "Cheese" Property should invoke the property Changed for "Cheese"
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForCheese()
        {
            var burger = new DakotaDoubleBurger();
            Assert.PropertyChanged(burger, "Cheese", () => {
                burger.Cheese = false;
            });
        }
        //test: Changing the "Cheese" Property should invoke the property Changed for "SpecialInstructions"
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new DakotaDoubleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () => {
                burger.Cheese = false;
            });
        }

        //test: Changing the "Tomato" Property should invoke the property Changed for "Tomato"
        [Fact]
        public void ChangingTomatoPropertyShouldInvokePropertyChangedForTomato()
        {
            var burger = new DakotaDoubleBurger();
            Assert.PropertyChanged(burger, "Tomato", () => {
                burger.Tomato = false;
            });
        }
        //test: Changing the "Tomato" Property should invoke the property Changed for "SpecialInstructions"
        [Fact]
        public void ChangingTomatoPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new DakotaDoubleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () => {
                burger.Tomato = false;
            });
        }

        //test: Changing the "Lettuce" Property should invoke the property Changed for "Lettuce"
        [Fact]
        public void ChangingLettucePropertyShouldInvokePropertyChangedForLettuce()
        {
            var burger = new DakotaDoubleBurger();
            Assert.PropertyChanged(burger, "Lettuce", () => {
                burger.Lettuce = false;
            });
        }
        //test: Changing the "Lettuce" Property should invoke the property Changed for "SpecialInstructions"
        [Fact]
        public void ChangingLettucePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new DakotaDoubleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () => {
                burger.Lettuce = false;
            });
        }

        //test: Changing the "Mayo" Property should invoke the property Changed for "Mayo"
        [Fact]
        public void ChangingMayoPropertyShouldInvokePropertyChangedForMayo()
        {
            var burger = new DakotaDoubleBurger();
            Assert.PropertyChanged(burger, "Mayo", () => {
                burger.Mayo = false;
            });
        }
        //test: Changing the "Mayo" Property should invoke the property Changed for "SpecialInstructions"
        [Fact]
        public void ChangingMayoPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new DakotaDoubleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () => {
                burger.Mayo = false;
            });
        }
        
    }
}
