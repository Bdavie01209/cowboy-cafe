/*

* Author: Blake Davies

* Class name: TexasTea.cs

* Purpose: to create the texastea class

*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTea : Drink
    {
        /// <summary>
        /// the price of the TexasTea drink base on size
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
                        return 1.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Large:
                        return 2.00;
                }
            }
        }
        /// <summary>
        /// the amount of calories inisde of the Texas Tea drink based on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Sweet)
                {
                    switch (Size)
                    {
                        default:
                            throw new NotImplementedException("Unknown Size");
                        case Size.Small:
                            return 10;
                        case Size.Medium:
                            return 22;
                        case Size.Large:
                            return 36;
                    }
                }
                else
                {
                    switch (Size)
                    {
                        default:
                            throw new NotImplementedException("Unknown Size");
                        case Size.Small:
                            return 5;
                        case Size.Medium:
                            return 11;
                        case Size.Large:
                            return 18;
                    }

                }
            }
        }
        /// <summary>
        /// a list of instructions based on the current Texas Soda drink 
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");
                if (Lemon) instructions.Add("Add Lemon");

                return instructions;
            }

        }

        private bool sweet = true;

        /// <summary>
        /// weather the tea has sugar in it
        /// </summary>
        public bool Sweet
        {
            get
            {
                return sweet;
            }
            set
            {
                sweet = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sweet"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ToString"));
            }
        }


        /// <summary>
        /// backing variable for lemon
        /// </summary>
        private bool lemon = false;

        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// weather the tea has a lemon in it
        /// </summary>
        public bool Lemon
        {
            get
            {
                return lemon;
            }
            set
            {
                lemon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// converts object to string
        /// </summary>
        /// <returns>returns formatted name of object</returns>
        public override string ToString()
        {
            string returnValue = Size.ToString();

            if (Sweet)
            {
                returnValue += " Texas Sweet Tea";
            }
            else
            {
                returnValue += " Texas Plain Tea";
            }

            return returnValue;
        }


    }
}
