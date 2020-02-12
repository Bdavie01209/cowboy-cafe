/*

* Author: Blake Davies

* Class name: water.cs

* Purpose: to create the water drink class

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// water drink class
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// the price of water always $.12
        /// </summary>
        public override double Price { get; } = .12;

        /// <summary>
        /// amount of calories in water always 0
        /// </summary>
        public override uint Calories { get; } = 0;

        /// <summary>
        /// speical instructions for the water drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold Ice");
                if (Lemon) instructions.Add("Add Lemon");

                return instructions;
            }
        }
        /// <summary>
        /// weather the drink has lemon in it
        /// </summary>
        public bool Lemon { get; set; } = false;
    }
}
