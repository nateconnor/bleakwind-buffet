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
    class MadOtarGrits
    {
        public double Price
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

        public uint Calories
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

        public Size Size
        {
            get; set;
        } = Size.Small;

        public List<String> SpecialInstructions
        {
            get
            {
                return SpecialInstructions;
            }
        }
        public override string ToString()
        {
            return $"{Size} Mad Otar Grits";
        }
    }
}

