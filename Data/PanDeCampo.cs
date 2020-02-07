/*

* Author: Blake Davies

* Class name: PanDeCampo.cs

* Purpose: to create the PanDeCampo entree class

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class for the pan de campo side
    /// </summary>
    public class PanDeCampo : Side
    {
        /// <summary>
        /// the cost of the pan de campo side based on size
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
        /// the amount of calores inside the pan de campo based on size
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
                        return 227;
                    case Size.Medium:
                        return 269;
                    case Size.Large:
                        return 367;
                }
            }
        }
    }
}
