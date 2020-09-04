﻿/*
* Author: Nathan Connor
* Class name: DragonbornWaffleFries.cs
* Purpose: Side object constructor for BleakwindBuffet
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class for representing Dragonborn Waffle Fries
    /// </summary>
    public class DragonbornWaffleFries
    {
        /// <summary>
        /// The Price of the side
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                    return .42;
                else if (Size == Size.Medium)
                    return .76;
                else
                    return .96;


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
                    return 77;
                else if (Size == Size.Medium)
                    return 89;
                else
                    return 100;

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
            return $"{Size} Dragonborn Waffle Fries";
        }
    }
}
