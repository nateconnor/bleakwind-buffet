
/*
* Author: Nathan Connor
* Class name: BriarheartBurger.cs
* Purpose: Entree object constructor for BleakwindBuffet
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class BriarheartBurger
    {
        public double Price
        {
            get
            {
                return 6.32;
            }
        } 

        public uint Calories
        {
            get
            {
                return 743;
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
                return SpecialInstructions;
            }
           
        }
            

        public bool Bun, Ketchup, Mustard, Pickle, Cheese = true;

        public override string ToString()
        {
            return "Briarheart Burger";
        }


    }
}
