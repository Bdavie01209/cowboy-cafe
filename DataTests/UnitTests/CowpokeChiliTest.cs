using System;
using System.Collections.Generic;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class CowpokeChiliTest
    {
        [Fact]
        public void DefaultPriceShouldBeCorrect()
        {
            var chili = new CowpokeChili();
            Assert.Equal(6.10, chili.Price);
        }

        [Fact]
        public void DefaultCaloriesShouldBeCorrect()
        {
            var chili = new CowpokeChili();
            Assert.Equal<uint>(171, chili.Calories);
        }

        [Fact]
        public void DefaultSpecialInstructionsShouldBeEmpty()
        {
            var chili = new CowpokeChili();
            Assert.Empty(chili.SpecialInstructions);
        }

        [Fact]
        public void HoldingCheeseShouldAddSpecialInstruction()
        {
            var chili = new CowpokeChili();
            chili.Cheese = false;
            Assert.Collection(chili.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold cheese", instruction);
            });
        }

        [Fact]
        public void HoldingSourCreamShouldAddSpecialInstruction()
        {
            var chili = new CowpokeChili();
            chili.SourCream = false;
            Assert.Collection(chili.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold sour cream", instruction);
            });
        }

        [Fact]
        public void HoldingGreenOnionsShouldAddSpecialInstruction()
        {
            var chili = new CowpokeChili();
            chili.GreenOnions = false;
            Assert.Collection(chili.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold green onions", instruction);
            });
        }

        [Fact]
        public void HoldingTortillaStripsShouldAddSpecialInstruction()
        {
            var chili = new CowpokeChili();
            chili.TortillaStrips = false;
            Assert.Collection(chili.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold tortilla strips", instruction);
            });
        }

        [Fact]
        public void HoldCheeseAndTortillaStripsShouldAddTwoSpecialInstructions()
        {
            var chili = new CowpokeChili();
            chili.Cheese = false;
            chili.TortillaStrips = false;
            Assert.Contains("hold cheese", chili.SpecialInstructions);
            Assert.Contains("hold tortilla strips", chili.SpecialInstructions);
        }

        [Fact]
        public void HoldCheeseSourCreamAndGreenOnionsShouldAddThreeSpecialInstructions()
        {
            var chili = new CowpokeChili();
            chili.Cheese = false;
            chili.SourCream = false;
            chili.GreenOnions = false;
            Assert.Contains("hold cheese", chili.SpecialInstructions);
            Assert.Contains("hold sour cream", chili.SpecialInstructions);
            Assert.Contains("hold green onions", chili.SpecialInstructions);
        }

        // test1: CowpokeChili should implement the inotifypropertychangedinterface
        [Fact]
        public void CowPokeChiliShouldImplentInotifyPropertyChanged()
        {
            var cowpokeChili = new CowpokeChili();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cowpokeChili);
        }


        // test2: changing the "Cheese" property should invoke propertychanged for "cheese"
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForCheese()
        {
            var cowpokeChili = new CowpokeChili();
            Assert.PropertyChanged(cowpokeChili, "Cheese", () => {
                cowpokeChili.Cheese = false;
            });
        }

        // test3: changing the "Cheese" property should invoke propertychanged for "SpecialInstrcutions"
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cowpokeChili = new CowpokeChili();
            Assert.PropertyChanged(cowpokeChili, "SpecialInstrcutions", () => {
                cowpokeChili.Cheese = false;
            });
        }
        // test4: changing the "SourCream" property should invoke propertychanged for "SourCream"
        [Fact]
        public void ChangingSourCreamPropertyShouldInvokePropertyChangedForSourCream()
        {
            var cowpokeChili = new CowpokeChili();
            Assert.PropertyChanged(cowpokeChili, "SourCream", () => {
                cowpokeChili.SourCream = false;
            });
        }

        // test5: changing the "SourCream" property should invoke propertychanged for "speicalInstruction"
        [Fact]
        public void ChangingSourCreamPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cowpokeChili = new CowpokeChili();
            Assert.PropertyChanged(cowpokeChili, "SpecialInstrcutions", () => {
                cowpokeChili.SourCream = false;
            });
        }




        //test: Changing the "TortillaStrips" Property should invoke the property Changed for "TortillaStrips"
        [Fact]
        public void ChangingTortillaStripsPropertyShouldInvokePropertyChangedForTortillaStrips()
        {
            var cowpokeChili = new CowpokeChili();
            Assert.PropertyChanged(cowpokeChili, "TortillaStrips", () => {
                cowpokeChili.TortillaStrips = false;
            });
        }
        //test: Changing the "TortillaStrips" Property should invoke the property Changed for "SpecialInstructions"
        [Fact]
        public void ChangingTortillaStripsPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cowpokeChili = new CowpokeChili();
            Assert.PropertyChanged(cowpokeChili, "SpecialInstructions", () => {
                cowpokeChili.TortillaStrips = false;
            });
        }


        //test: Changing the "GreenOnions" Property should invoke the property Changed for "GreenOnions"
        [Fact]
        public void ChangingGreenOnionsPropertyShouldInvokePropertyChangedForGreenOnions()
        {
            var cowpokeChili = new CowpokeChili();
            Assert.PropertyChanged(cowpokeChili, "GreenOnions", () => {
                cowpokeChili.GreenOnions = false;
            });
        }
        //test: Changing the "GreenOnions" Property should invoke the property Changed for "SpecialInstructions"
        [Fact]
        public void ChangingGreenOnionsPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cowpokeChili = new CowpokeChili();
            Assert.PropertyChanged(cowpokeChili, "SpecialInstructions", () => {
                cowpokeChili.GreenOnions = false;
            });
        }
    }
}