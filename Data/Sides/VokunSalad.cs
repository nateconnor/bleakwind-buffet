/*
* Author: Nathan Connor
* Class name: VokunSalad.cs
* Purpose: Side object constructor for BleakwindBuffet
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;



namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class for representing Vokun Salad
    /// </summary>
    public class VokunSalad : Side, IOrderItem
    {
        /// <summary>
        /// The Price of the side
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                    return .93;
                else if (Size == Size.Medium)
                    return 1.28;
                else
                    return 1.82;


            }
        }

        /// <summary>
        /// A list of special insturctions for preparing the side
        /// </summary>
        public override List<String> SpecialInstructions
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
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                    return 41;
                else if (Size == Size.Medium)
                    return 52;
                else
                    return 73;

            }
        }




        /// <summary>
        /// Returns a description of the side
        /// </summary>
        /// <returns> A string describing the side</returns>
        public override string ToString()
        {
            return $"{Size} Vokun Salad";
        }
    }
}

