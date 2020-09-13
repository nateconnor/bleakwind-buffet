
/*
* Author: Nathan Connor
* Class name: BriarheartBurger.cs
* Purpose: Entree object constructor for BleakwindBuffet
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for representing Briarheart Burger
    /// </summary>
    public class BriarheartBurger : Entree, IOrderItem
    {
        /// <summary>
        /// The Price of the entree
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.32;
            }
        }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 743;
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
                if (!Bun)
                {
                    SpecialInstructions.Add("Hold Bun");
                }
                if (!Ketchup)
                {
                    SpecialInstructions.Add("Hold Ketchup");
                }
                if (!Mustard)
                {
                    SpecialInstructions.Add("Hold Mustard");
                }
                if (!Pickle)
                {
                    SpecialInstructions.Add("Hold Pickle");
                }
                if (!Cheese)
                {
                    SpecialInstructions.Add("Hold Cheese");
                }
                return SpecialInstructions;
            }

        }

        /// <summary>
        /// Whether or not the entree has bun
        /// </summary>
        public bool Bun { get; set; } = true;
        /// <summary>
        /// Whether or not the entree has ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;
        /// <summary>
        /// Whether or not the entree has mustard
        /// </summary>
        public bool Mustard { get; set; } = true;
        /// <summary>
        /// Whether or not the entree has Pickle
        /// </summary>
        public bool Pickle { get; set; } = true;
        /// <summary>
        /// Whether or not the entree has Cheese
        /// </summary>
        public bool Cheese { get; set; } = true;
        

        /// <summary>
        /// Returns a description of the entree
        /// </summary>
        /// <returns> A string describing the entree</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }


    }
}
