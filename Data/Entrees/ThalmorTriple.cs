using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class ThalmorTriple
    {
        public double Price
        {
            get
            {
                return 8.32;
            }
        }

        public uint Calories
        {
            get
            {
                return 943;
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
                if (!Bacon)
                {
                    SpecialInstructions.Add("Hold Bacon");
                }
                if (!Egg)
                {
                    SpecialInstructions.Add("Hold Egg");
                }
                return SpecialInstructions;
            }

        }

        public bool Bun, Ketchup, Mustard, Pickle, Cheese, Tomato, Lettuce, Mayo, Bacon, Egg = true;

        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
