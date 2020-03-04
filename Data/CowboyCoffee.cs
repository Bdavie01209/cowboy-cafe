/*

* Author: Blake Davies

* Class name: CowboyCoffee.cs

* Purpose: to create the CowBoycoffee class
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// the CowboyCoffee drink class
    /// </summary>
    public class CowboyCoffee : Drink
    {
        /// <summary>
        /// the price of the cowboy coffee drink based on the size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    default:
                        throw new NotImplementedException("Unknown Size");
                    case Size.Small:
                        return .60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
                }
            }
        }
        /// <summary>
        /// the amount of calories inisde the cowboy coffee drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    default:
                        throw new NotImplementedException("Unknown Size");
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                }
            }
        }
        /// <summary>
        /// special instructions for the cowboy coffee drinki
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (Ice) instructions.Add("Add Ice");
                if (RoomForCream) instructions.Add("Room for Cream");

                return instructions;
            }

        }
        /// <summary>
        /// the weather the cowbo coffee drink has ice
        /// </summary>
        public override bool Ice { get; set; } = false;
        /// <summary>
        /// weather there should be room for cream in the coffee
        /// </summary>
        public bool RoomForCream { get; set; } = false;
        /// <summary>
        /// weather the coffee is decaf or not
        /// </summary>
        public bool Decaf { get; set; } = false;

        public override event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// converts object to string
        /// </summary>
        /// <returns>returns formatted name of object</returns>
        public override string ToString()
        {
            string returnValue = Size.ToString();
            if (Decaf) returnValue += " Decaf";
            returnValue += " Cowboy Coffee";
            return returnValue;
        }
    }
}
