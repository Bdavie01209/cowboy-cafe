﻿/*

* Author: Blake Davies

* Class name: AngryChicken.cs

* Purpose: to create the AngryChicken class

*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a Class to represent the AngryChicken Sandwitch
    /// </summary>
    public class AngryChicken : Entree
    {


        /// <summary>
        /// private value for bread variable
        /// </summary>
        private bool bread = true;
        /// <summary>
        /// if the AngryChicken is served with bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set 
            { 
                bread = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bread"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            
            }
        }
        /// <summary>
        /// if the Angrychicken is served with a Pickle
        /// </summary>

        private bool pickle = true;

        public override event PropertyChangedEventHandler PropertyChanged;

        public bool Pickle 
        { 
            get 
            {
                return pickle;
            } 
            set 
            {
                pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            } 
        }

        /// <summary>
        /// the price of the AngryChicken
        /// </summary>
        public override double Price
        {
            get { return 5.99; }
        }
        /// <summary>
        /// the number of calories inside the Angrychicken
        /// </summary>
        public override uint Calories
        {
            get { return 190; }
        }

        /// <summary>
        /// a list of special instructions for this AngryChicken
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Bread)
                {
                    instructions.Add("hold bread");
                }
                if (!Pickle)
                {
                    instructions.Add("hold pickle");
                }

                return instructions;

            }
        }

        /// <summary>
        /// converts object to string
        /// </summary>
        /// <returns>returns formatted name of object</returns>
        public override string ToString()
        {
            return "Angry Chicken";
        }
    }
}
