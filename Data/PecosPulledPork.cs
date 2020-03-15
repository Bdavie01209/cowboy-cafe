/*

* Author: Blake Davies

* Class name: PecosPulledPork.cs

* Purpose: to create the PecosPulledPork entree class

*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// class for the Pescos Pulled Pork Entree
    /// </summary>
    public class PecosPulledPork : Entree
    {
        /// <summary>
        /// the price of the pesco pulled pork Entree
        /// </summary>
        public override double Price
        {
            get { return 5.88; }
        }

        /// <summary>
        /// the amount of calories inside the pesco pulled pork entree
        /// </summary>
        public override uint Calories
        {
            get { return 528; }
        }

        private bool bread = true;



        /// <summary>
        /// weather the pulled pork is served with bread
        /// </summary>
        public bool Bread
        {
            get
            {
                return bread;
            }
            set
            {
                bread = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bread"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool pickle = true;

        /// <summary>
        /// weather the pulled pork is served with pickles
        /// </summary>
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
        /// a list of the speicalinstructions for the pulled pork
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Bread) { instructions.Add("hold bread"); }
                if (!Pickle) { instructions.Add("hold pickle"); }


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
            return "Pecos Pulled Pork";
        }
    }
}
