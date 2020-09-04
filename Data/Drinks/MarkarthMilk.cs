/*
* Author: Nathan Connor
* Class name: MarkarthMilk.cs
* Purpose: Drink object constructor for BleakwindBuffet
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class for representing Markarth Milk
    /// </summary>
    public class MarkarthMilk
    {
        /// <summary>
        /// The Price of the drink
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                    return 1.05;
                else if (Size == Size.Medium)
                    return 1.11;
                else
                    return 1.22;


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
                    return 56;
                else if (Size == Size.Medium)
                    return 72;
                else
                    return 93;

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
            return $"{Size} Markarth Milk";
        }
    }
}

