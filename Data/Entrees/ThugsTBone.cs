/*
* Author: Nathan Connor
* Class name: ThugsTBone.cs
* Purpose: Entree object constructor for BleakwindBuffet
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class ThugsTBone
    {
        public double Price
        {
            get
            {
                return 6.44;
            }
        }

        public uint Calories
        {
            get
            {
                return 982;
            }
        }


        public List<String> SpecialInstructions { get; set; }

        

        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}

