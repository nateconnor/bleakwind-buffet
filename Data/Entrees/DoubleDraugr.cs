/*
* Author: Nathan Connor
* Class name: DoubleDraugr.cs
* Purpose: Entree object constructor for BleakwindBuffet
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class DoubleDraugr
    {
        public double Price
        {
            get
            {
                return 7.32;
            }
        }

        public uint Calories
        {
            get
            {
                return 843;
            }
        }

        public List<String> SpecialInstructions
        {
            get
            {
                if (!Bun)
                {
                    SpecialInstructions.Add("Hold Bun");
                }
                if (!Ketchup)
                {
                    SpecialInstructions.Add("Hold Ketchup");
                }
                if (!Mustard)
                {
                    SpecialInstructions.Add("Hold Mustard");
                }
                if (!Pickle)
                {
                    SpecialInstructions.Add("Hold Pickle");
                }
                if (!Cheese)
                {
                    SpecialInstructions.Add("Hold Cheese");
                }
                if (!Tomato)
                {
                    SpecialInstructions.Add("Hold Tomato");
                }
                if (!Lettuce)
                {
                    SpecialInstructions.Add("Hold Lettuce");
                }
                if (!Mayo)
                {
                    SpecialInstructions.Add("Hold Mayo");
                }
                return SpecialInstructions;
            }

        }

        public bool Bun, Ketchup, Mustard, Pickle, Cheese, Tomato, Lettuce, Mayo = true;

        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
