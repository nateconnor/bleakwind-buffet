/*
* Author: Nathan Connor
* Class name: FriedMiraak.cs
* Purpose: Side object constructor for BleakwindBuffet
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class for representing Fried Miraak
    /// </summary>
    public class FriedMiraak
    {
        /// <summary>
        /// The Price of the side
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                    return 1.78;
                else if (Size == Size.Medium)
                    return 2.01;
                else
                    return 2.88;


            }
        }

        /// <summary>
        /// A list of special insturctions for preparing the side
        /// </summary>
        public List<String> SpecialInstructions
        {
            get
            {
                List<String> SpecialInstructions = new List<string>();
                return SpecialInstructions;
            }
        }

        /// <summary>
        /// The calories of the side
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                    return 151;
                else if (Size == Size.Medium)
                    return 236;
                else
                    return 306;

            }
        }

        /// <summary>
        /// The size of the side
        /// </summary>
        public Size Size
        {
            get; set;
        } = Size.Small;

        /// <summary>
        /// Returns a description of the side
        /// </summary>
        /// <returns> A string describing the side</returns>
        public override string ToString()
        {
            return $"{Size} Fried Miraak";
        }
    }
}

