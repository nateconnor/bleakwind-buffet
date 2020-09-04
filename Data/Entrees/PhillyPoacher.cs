/*
* Author: Nathan Connor
* Class name: PhillyPoacher.cs
* Purpose: Entree object constructor for BleakwindBuffet
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for representing Philly Poacher
    /// </summary>
    public class PhillyPoacher
    {
        /// <summary>
        /// The Price of the entree
        /// </summary>
        public double Price
        {
            get
            {
                return 7.23;
            }
        }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public uint Calories
        {
            get
            {
                return 784;
            }
        }

        /// <summary>
        /// A list of special insturctions for preparing the entree
        /// </summary>
        public List<String> SpecialInstructions
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

        /// <summary>
        /// Whether or not the entree has Sirloin
        /// </summary>
        public bool Sirloin { get; set; } = true;
        /// <summary>
        /// Whether or not the entree has Onion
        /// </summary>
        public bool Onion { get; set; } = true;
        /// <summary>
        /// Whether or not the entree has a Roll
        /// </summary>
        public bool Roll { get; set; } = true;

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
