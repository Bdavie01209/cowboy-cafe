using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class for the corn dodgers side
    /// </summary>
    public class CornDodgers : Side
    {
        /// <summary>
        /// the price of the corn dodgers side based on size
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
        /// the calores inside the corn dodgers side based on size
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
                        return 512;
                    case Size.Medium:
                        return 685;
                    case Size.Large:
                        return 717;
                }
            }
        }
    }
}
