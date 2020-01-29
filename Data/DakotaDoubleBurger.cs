﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class DakotaDoubleBurger
    {
        /// <summary>
        /// the price of the dakota double burger entree
        /// </summary>
        public double Price
        {
            get { return 5.20; }
        }

        /// <summary>
        /// the amount of calories inside the dakota double burger entree
        /// </summary>
        public uint Calories
        {
            get { return 464; }
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
        /// a list of speical instructions for this burger
        /// </summary>
        public List<string> SpecialInstructions
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

                return instructions;
            }
        }



    }
}