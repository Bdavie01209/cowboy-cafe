/*

* Author: Blake Davies

* Class name: TexasTripleBurger.cs

* Purpose: to create the TexasTripleBurger entree class

*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class for the TexasTripleBurger entree
    /// </summary>
    public class TexasTripleBurger : Entree
    {
        /// <summary>
        /// the price of the TexasTripleBurger entree
        /// </summary>
        public override double Price
        {
            get { return 6.45; }
        }

        /// <summary>
        /// the amount of calories inside the TexasTripleBurger entree
        /// </summary>
        public override uint Calories
        {
            get { return 698; }
        }

        /// <summary>
        /// weather the hamburger is served with a bun
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// weather the sandwitch is served with catsup
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// weather the sandwitch is served with mustard
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// weather the sandwitch is served with pickles
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// weather the sandwitch is served with cheese
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// weather the sandwich has tomatos
        /// </summary>
        public bool Tomato { get; set; } = true;
        /// <summary>
        /// weather the sandwitch has lettuce
        /// </summary>
        public bool Lettuce { get; set; } = true;
        /// <summary>
        /// weather the sandwitch has mayo
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// weather the sandwitch has bacon on it
        /// </summary>
        public bool Bacon { get; set; } = true;

        /// <summary>
        /// weather the sandwitch has egg on it
        /// </summary>
        public bool Egg { get; set; } = true;


        /// <summary>
        /// a list of speical instructions for this burger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Bun) instructions.Add("hold bun");
                if (!Ketchup) instructions.Add("hold ketchup");
                if (!Mustard) instructions.Add("hold mustard");
                if (!Pickle) instructions.Add("hold pickle");
                if (!Cheese) instructions.Add("hold cheese");
                if (!Mayo) instructions.Add("hold mayo");
                if (!Lettuce) instructions.Add("hold lettuce");
                if (!Tomato) instructions.Add("hold tomato");
                if (!Bacon) instructions.Add("hold bacon");
                if (!Egg) instructions.Add("hold egg");


                return instructions;
            }
        }

        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// converts object to string
        /// </summary>
        /// <returns>returns formatted name of object</returns>
        public override string ToString()
        {
            return "Texas Triple Burger";
        }


    }
}
