using System;
using System.Collections.Generic;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class AngryChickenTest
    {
        [Fact]
        public void DefaultPriceShouldBeCorrect()
        {
            var chicken = new AngryChicken();
            Assert.Equal(5.99, chicken.Price);
        }

        [Fact]
        public void DefaultCaloriesShouldBeCorrect()
        {
            var chicken = new AngryChicken();
            Assert.Equal<uint>(190, chicken.Calories);
        }

        [Fact]
        public void DefaultSpecialInstructionsShouldBeEmpty()
        {
            var chicken = new AngryChicken();
            Assert.Empty(chicken.SpecialInstructions);
        }

        [Fact]
        public void HoldingBreadShouldAddSpecialInstruction()
        {
            var chicken = new AngryChicken();
            chicken.Bread = false;
            Assert.Collection(chicken.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold bread", instruction);
            });
        }

        [Fact]
        public void HoldingPickleShouldAddSpecialInstruction()
        {
            var chicken = new AngryChicken();
            chicken.Pickle = false;
            Assert.Collection(chicken.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold pickle", instruction);
            });
        }

        [Fact]
        public void HoldingBothBreadAndPickleShouldAddTwoSpecialInstructions()
        {
            var chicken = new AngryChicken();
            chicken.Bread = false;
            chicken.Pickle = false;
            Assert.Contains("hold pickle", chicken.SpecialInstructions);
            Assert.Contains("hold bread", chicken.SpecialInstructions);
        }


        // test1: angry chicken should implement the inotifypropertychangedinterface
        [Fact]
        public void AngryChickenShouldImplentInotifyPropertyChanged()
        {
            var chicken = new AngryChicken();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chicken);
        }


        // test2: chaning the "Bread" property should invoke propertychanged for "Bread"
        [Fact]
        public void ChangingBreadPropertyShouldInvokePropertyChangedForBread()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "Bread", () => {
                chicken.Bread = false;
            });
        }

        // test3: chaning the "Bread" property should invoke propertychanged for "SpecialInstrcutions"
        [Fact]
        public void ChangingBreadPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "SpecialInstrcutions", () => {
                chicken.Bread = false;
            });
        }
        // test4: chaning the "Pickle" property should invoke propertychanged for "Pickle"
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "Pickle", () => {
                chicken.Pickle = false;
            });
        }

        // test5: chaning the "Pickle" property should invoke propertychanged for "speicalInstruction"
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "SpecialInstrcutions", () => {
                chicken.Pickle = false;
            });
        }




    }
}
