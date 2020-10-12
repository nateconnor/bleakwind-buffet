/*
* Author: Nathan Connor
* Class name: PhillyPoacher.cs
* Purpose: Entree object constructor for BleakwindBuffet
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for representing Philly Poacher
    /// </summary>
    public class PhillyPoacher : Entree, IOrderItem
    {
        /// <summary>
        /// The Price of the entree
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.23;
            }
        }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 784;
            }
        }

        /// <summary>
        /// A list of special insturctions for preparing the entree
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<String> SpecialInstructions = new List<String>();

                if (!Sirloin)
                {
                    SpecialInstructions.Add("Hold sirloin");
                }
                if (!Onion)
                {
                    SpecialInstructions.Add("Hold onions");
                }
                if (!Roll)
                {
                    SpecialInstructions.Add("Hold roll");
                }
               

                return SpecialInstructions;
            }

        }

        private bool _sirloin = true;
        private bool _onion = true;

        private bool _roll = true;

        /// <summary>
        /// Whether or not the entree has Sirloin
        /// </summary>
        public bool Sirloin
        {
            get => _sirloin;
            set
            {
                _sirloin = value;
                InvokePropertyChanged("Sirloin");
                InvokePropertyChanged("SpecialInstructions");

            }

        }
        /// <summary>
        /// Whether or not the entree has Onion
        /// </summary>
        public bool Onion
        {
            get => _onion;
            set
            {
                _onion = value;
                InvokePropertyChanged("Onion");
                InvokePropertyChanged("SpecialInstructions");

            }

        }
        /// <summary>
        /// Whether or not the entree has a Roll
        /// </summary>
        public bool Roll
        {
            get => _roll;
            set
            {
                _roll = value;
                InvokePropertyChanged("Roll");
                InvokePropertyChanged("SpecialInstructions");

            }

        }


        /// <summary>
        /// Returns a description of the entree
        /// </summary>
        /// <returns> A string describing the entree</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
