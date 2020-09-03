/*
* Author: Nathan Connor
* Class name: PhillyPoacher.cs
* Purpose: Entree object constructor for BleakwindBuffet
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher
    {
        public double Price
        {
            get
            {
                return 7.23;
            }
        }

        public uint Calories
        {
            get
            {
                return 784;
            }
        }

        public List<String> SpecialInstructions
        {
            get
            {
                if (!Sirloin)
                {
                    SpecialInstructions.Add("Hold Sirloin");
                }
                if (!Onion)
                {
                    SpecialInstructions.Add("Hold Onions");
                }
                if (!Roll)
                {
                    SpecialInstructions.Add("Hold Roll");
                }
               

                return SpecialInstructions;
            }

        }

        public bool Sirloin, Onion, Roll = true;

        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
