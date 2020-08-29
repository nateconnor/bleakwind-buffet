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
    class MarkarthMilk
    {
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
            return $"{Size} Markarth Milk";
        }
    }
}

