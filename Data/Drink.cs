/*

* Author: Blake Davies

* Class name: Drink.cs

* Purpose: to create the Drink base class

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// default drink class
    /// </summary>
    public abstract class Drink
    {

        /// <summary>
        /// the price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// the amount of calories inside the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// the ingredients inside the drink
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// the size of the drink
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// weather the drink contains ice
        /// </summary>
        public bool Ice { get; set; } = true;


    }
}
