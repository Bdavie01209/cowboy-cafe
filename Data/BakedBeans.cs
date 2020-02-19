/*

* Author: Blake Davies

* Class name: BakedBeans.cs

* Purpose: to create the BakedBeans class

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class for the baked beans side
    /// </summary>
    public class BakedBeans : Side
    {
        /// <summary>
        /// the price of the baked beans base on the size
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
                        return 1.59;
                    case Size.Medium:
                        return 1.79;
                    case Size.Large:
                        return 1.99;
                }
            }
        }

        /// <summary>
        /// the amount of calories inside baked beans based on the size
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
                        return 312;
                    case Size.Medium:
                        return 378;
                    case Size.Large:
                        return 410;
                }
            }
        }

        /// <summary>
        /// converts object to string
        /// </summary>
        /// <returns>returns formatted name of object</returns>
        public override string ToString()
        {
            return Size.ToString() + " Baked Beans";
        }
    }
}
