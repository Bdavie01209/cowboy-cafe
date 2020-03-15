/*

* Author: Blake Davies

* Class name: ChiliCheeseFries.cs

* Purpose: to create the ChiliCheeseFries class

*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// class for the chili cheese fries side
    /// </summary>
    public class ChiliCheeseFries : Side
    {
        /// <summary>
        /// the price of the chili cheese fries base on the size
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
                        return 1.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Large:
                        return 3.99;
                }
            }
        }

        /// <summary>
        /// the amount of calories inside the chili cheese fries based on the size
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
                        return 433;
                    case Size.Medium:
                        return 524;
                    case Size.Large:
                        return 610;
                }
            }
        }


        /// <summary>
        /// converts object to string
        /// </summary>
        /// <returns>returns formatted name of object</returns>
        public override string ToString()
        {
            return Size.ToString() + " Chili Cheese Fries";
        }
    }
}
