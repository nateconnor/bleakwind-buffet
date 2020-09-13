/*
* Author: Nathan Connor
* Class name: ThalmorTriple.cs
* Purpose: Entree object constructor for BleakwindBuffet
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for representing Thalmor Triple
    /// </summary>
    public class ThalmorTriple : Entree, IOrderItem
    {
        /// <summary>
        /// The Price of the entree
        /// </summary>
        public override double Price
        {
            get
            {
                return 8.32;
            }
        }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 943;
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
                if (!Tomato)
                {
                    SpecialInstructions.Add("Hold Tomato");
                }
                if (!Lettuce)
                {
                    SpecialInstructions.Add("Hold Lettuce");
                }
                if (!Mayo)
                {
                    SpecialInstructions.Add("Hold Mayo");
                }
                if (!Bacon)
                {
                    SpecialInstructions.Add("Hold Bacon");
                }
                if (!Egg)
                {
                    SpecialInstructions.Add("Hold Egg");
                }
                return SpecialInstructions;
            }

        }
        /// <summary>
        /// Whether or not the entree has bun
        /// </summary>
        public bool Bun { get; set; } = true;
        /// <summary>
        /// Whether or not the entree has Ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;
        /// <summary>
        /// Whether or not the entree has Mustard
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
        /// Whether or not the entree has Tomato
        /// </summary>
        public bool Tomato { get; set; } = true;
        /// <summary>
        /// Whether or not the entree has Lettuce
        /// </summary>
        public bool Lettuce { get; set; } = true;
        /// <summary>
        /// Whether or not the entree has Mayo
        /// </summary>
        public bool Mayo { get; set; } = true;
        /// <summary>
        /// Whether or not the entree has Bacon
        /// </summary>
        public bool  Bacon { get; set; } = true;
        /// <summary>
        /// Whether or not the entree has Egg
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// Returns a description of the entree
        /// </summary>
        /// <returns> A string describing the entree</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
