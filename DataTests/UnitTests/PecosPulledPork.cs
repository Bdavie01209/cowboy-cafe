using System;
using System.Collections.Generic;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class PecosPulledPorkTest
    {
        [Fact]
        public void DefaultPriceShouldBeCorrect()
        {
            var pulledPork = new PecosPulledPork();
            Assert.Equal(5.88, pulledPork.Price);
        }

        [Fact]
        public void DefaultCaloriesShouldBeCorrect()
        {
            var pulledPork = new PecosPulledPork();
            Assert.Equal<uint>(528, pulledPork.Calories);
        }

        [Fact]
        public void DefaultSpecialInstructionsShouldBeEmpty()
        {
            var pulledPork = new PecosPulledPork();
            Assert.Empty(pulledPork.SpecialInstructions);
        }

        [Fact]
        public void HoldingBreadShouldAddSpecialInstruction()
        {
            var pulledPork = new PecosPulledPork();
            pulledPork.Bread = false;
            Assert.Collection(pulledPork.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold bread", instruction);
            });
        }

        [Fact]
        public void HoldingPickleShouldAddSpecialInstruction()
        {
            var pulledPork = new PecosPulledPork();
            pulledPork.Pickle = false;
            Assert.Collection(pulledPork.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold pickle", instruction);
            });
        }

        [Fact]
        public void HoldingBothBreadAndPickleShouldAddTwoSpecialInstructions()
        {
            var pulledPork = new PecosPulledPork();
            pulledPork.Bread = false;
            pulledPork.Pickle = false;
            Assert.Contains("hold pickle", pulledPork.SpecialInstructions);
            Assert.Contains("hold bread", pulledPork.SpecialInstructions);
        }


        // test1: PecosPulledPork should implement the inotifypropertychangedinterface
        [Fact]
        public void PecosPulledPorkShouldImplentInotifyPropertyChanged()
        {
            var pork = new PecosPulledPork();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pork);
        }






        //test: Changing the "Bread" Property should invoke the property Changed for "Bread"
        [Fact]
        public void ChangingBreadPropertyShouldInvokePropertyChangedForBread()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "Bread", () => {
                pork.Bread = false;
            });
        }
        //test: Changing the "Bread" Property should invoke the property Changed for "SpecialInstructions"
        [Fact]
        public void ChangingBreadPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "SpecialInstructions", () => {
                pork.Bread = false;
            });
        }
        //test: Changing the "Pickle" Property should invoke the property Changed for "Pickle"
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "Pickle", () => {
                pork.Pickle = false;
            });
        }
        //test: Changing the "Pickle" Property should invoke the property Changed for "SpecialInstructions"
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "SpecialInstructions", () => {
                pork.Pickle = false;
            });
        }
    }
}
