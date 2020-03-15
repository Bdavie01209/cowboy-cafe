/*

* Author: Blake Davies

* Class name: JerkedSoda.cs

* Purpose: to create the JerkedSoda class

*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// class for the jerked soda drink
    /// </summary>
    public class JerkedSoda : Drink
    {
        /// <summary>
        /// the price of the jerked soda drink base on size
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
                        return 2.10;
                    case Size.Large:
                        return 2.59;
                }
            }
        }
        /// <summary>
        /// the amount of calories inisde of the jerked soda drink based on size
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
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                }
            }
        }
        /// <summary>
        /// a list of instructions based on the current jerkedsoda drink 
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");

                return instructions;
            }

        }


        private Size size = Size.Small;

        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ToString"));
            }
        }


        private bool ice = true;

        public override bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ToString"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }







        private SodaFlavor flavor = SodaFlavor.CreamSoda;

        /// <summary>
        /// the flavor of the drink
        /// </summary>
        public SodaFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ToString"));
            }
        }

        public override event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// converts object to string
        /// </summary>
        /// <returns>returns formatted name of object</returns>
        public override string ToString()
        {
            string returnValue = Size.ToString();

            switch (Flavor)
            {
                case SodaFlavor.BirchBeer:
                    returnValue += " Birch Beer";
                    break;
                case SodaFlavor.CreamSoda:
                    returnValue += " Cream Soda";
                    break;
                case SodaFlavor.OrangeSoda:
                    returnValue += " Orange Soda";
                    break;
                case SodaFlavor.RootBeer:
                    returnValue += " Root Beer";
                    break;
                case SodaFlavor.Sarsparilla:
                    returnValue += " Sarsparilla";
                    break;
                default:
                    throw new NotImplementedException("Unknown Flavor");
            }

            returnValue += " Jerked Soda";

            return returnValue;
        }
    }
}
