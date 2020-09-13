/*
* Author: Nathan Connor
* Class name: MadOtarGrits.cs
* Purpose: Side object constructor for BleakwindBuffet
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class for representing Mad Otar Grits
    /// </summary>
    public class MadOtarGrits : Side, IOrderItem
    {
        /// <summary>
        /// The Price of the side
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                    return 1.22;
                else if (Size == Size.Medium)
                    return 1.58;
                else
                    return 1.93;


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
                    return 105;
                else if (Size == Size.Medium)
                    return 142;
                else
                    return 179;

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
        /// Returns a description of the side
        /// </summary>
        /// <returns> A string describing the side</returns>
        public override string ToString()
        {
            return $"{Size} Mad Otar Grits";
        }
    }
}

