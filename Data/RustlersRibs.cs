/*

* Author: Blake Davies

* Class name: RustlersRibs.cs

* Purpose: to create the RustlersRibs entree class

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class for the RusterRibs Entre
    /// </summary>
    public class RustlersRibs : Entree
    {
        /// <summary>
        /// the price of the Rustler's Ribs
        /// </summary>
        public override double Price
        {
            get { return 7.50; }
        }

        /// <summary>
        /// the Calories of the Rustler's Ribs
        /// </summary>
        public override uint Calories
        {
            get { return 894; }
        }

        /// <summary>
        /// the special instructions for the Rustler ribs currently there are none.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                return new List<string>();
            }
        }

    }
}
