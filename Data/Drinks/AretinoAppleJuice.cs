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
    class AretinoAppleJuice
    {
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

        public Size Size
        {
            get; set;
        } = Size.Small;

       

        public bool Ice { get; set; } = false;

        public List<String> SpecialInstructions
        {
            get
            {
                if (Ice)
                {
                    SpecialInstructions.Add("Add ice");
                }
                
                return SpecialInstructions;
            }
        }



        public override string ToString()
        {
            return $"{Size} Aretino Apple Juice";
        }
    }
}

