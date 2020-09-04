/*
* Author: Nathan Connor
* Class name: AretinoAppleJuice.cs
* Purpose: Drink object constructor for BleakwindBuffet
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class for representing Aretino Apple Juice
    /// </summary>
    public class AretinoAppleJuice
    {
        /// <summary>
        /// The Price of the drink
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                    return .62;
                else if (Size == Size.Medium)
                    return .87;
                else
                    return 1.01;


            }
        }

        /// <summary>
        /// The calories of the drink
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                    return 44;
                else if (Size == Size.Medium)
                    return 88;
                else
                    return 132;

            }
        }

        /// <summary>
        /// The size of the drink
        /// </summary>
        public Size Size
        {
            get; set;
        } = Size.Small;


        /// <summary>
        /// Whether or not the drink has ice
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// A list of special insturctions for preparing the drink
        /// </summary>
        public List<String> SpecialInstructions
        {
            get
            {
                List<String> SpecialInstructions = new List<string>();

                if (Ice)
                {
                    SpecialInstructions.Add("Add ice");
                }
                
                return SpecialInstructions;
            }
        }


        /// <summary>
        /// Returns a description of the drink
        /// </summary>
        /// <returns> A string describing the drink</returns>
        public override string ToString()
        {
            return $"{Size} Aretino Apple Juice";
        }
    }
}

