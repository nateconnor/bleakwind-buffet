/*
* Author: Nathan Connor
* Class name: GardenOrcOmelette.cs
* Purpose: Entree object constructor for BleakwindBuffet
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette
    {
        public double Price
        {
            get
            {
                return 4.57;
            }
        }

        public uint Calories
        {
            get
            {
                return 404;
            }
        }

        public List<String> SpecialInstructions
        {
            get { 
                if (!Broccoli)
                {
                    SpecialInstructions.Add("Hold Broccoli");
                }
                if (!Mushrooms)
                {
                    SpecialInstructions.Add("Hold Mushrooms");
                }
                if (!Tomato)
                {
                    SpecialInstructions.Add("Hold Tomato");
                }
                if (!Cheddar)
                {
                    SpecialInstructions.Add("Hold Cheddar");
                }
                
                return SpecialInstructions;
            }

        }

        public bool Broccoli, Mushrooms, Tomato, Cheddar = true;

        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
