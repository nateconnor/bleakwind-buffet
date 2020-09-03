/*
* Author: Nathan Connor
* Class name: SailorSoda.cs
* Purpose: Drink object constructor for BleakwindBuffet
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda
    {
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                    return 1.42;
                else if (Size == Size.Medium)
                    return 1.74;
                else 
                    return 2.07;
                

            }
        }

        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                    return 117;
                else if (Size == Size.Medium)
                    return 153;
               else 
                    return 205;
                
            }
        }

        public Size Size
        {
            get; set;
        } = Size.Small;

        public SodaFlavor Flavor
        {
            get; set;
        } = SodaFlavor.Cherry;

        public bool Ice { get; set; } =  true;        

        public List<String> SpecialInstructions
        {
            get
            {
                if (!Ice)
                {
                    SpecialInstructions.Add("Hold ice");
                }
                return SpecialInstructions;
            }
        }



        public override string ToString()
        {
            return $"{Size} {Flavor} Sailor Soda";
        }
    }
}
