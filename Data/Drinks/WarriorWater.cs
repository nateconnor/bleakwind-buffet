/*
* Author: Nathan Connor
* Class name: WarriorWater.cs
* Purpose: Drink object constructor for BleakwindBuffet
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace Data.Drinks
{
    class WarriorWater
    {
        public double Price
        {
            get
            {
                return 0;
            }
        }

        public uint Calories
        {
            get
            {
                return 0;
            }
        }

        public Size Size
        {
            get; set;
        } = Size.Small;

        

        public bool Ice = true;
        public bool Lemon = false;

        public List<String> SpecialInstructions
        {
            get
            {
                if (!Ice)
                {
                    SpecialInstructions.Add("Hold ice");
                }
                if (Lemon)
                {
                    SpecialInstructions.Add("Add Lemon");
                }
                return SpecialInstructions;
            }
        }



        public override string ToString()
        {
            return $"{Size} Warrior Water";
        }
    }
}

