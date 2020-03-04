/*

* Author: Blake Davies

* Class name: Drink.cs

* Purpose: to create the Drink base class

*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// default drink class
    /// </summary>
    public abstract class Drink : IOrderItem
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
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// the size of the drink
        /// </summary>
        public virtual Size Size { get; set; } = Size.Small;

        /// <summary>
        /// weather the drink contains ice
        /// </summary>
        public virtual bool Ice { get; set; } = true;

        /// <summary>
        /// requried for everything to update
        /// </summary>
        public abstract event PropertyChangedEventHandler PropertyChanged;
    }
}
