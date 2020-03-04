/*

* Author: Blake Davies

* Class name: Entree.cs

* Purpose: to create the Entree interface

*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Entree : IOrderItem
    {
        /// <summary>
        /// the price of the entree as each entree has a price
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// the amount of calories inside the entree
        /// </summary>
        public abstract uint Calories { get; }


        /// <summary>
        // A list of speical instructions for the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// requried for everything to update
        /// </summary>
        public abstract event PropertyChangedEventHandler PropertyChanged;
    }
}
