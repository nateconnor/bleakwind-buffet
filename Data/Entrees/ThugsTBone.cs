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
    /// <summary>
    /// Class for representing Thugs T bone
    /// </summary>
    public class ThugsTBone
    {
        /// <summary>
        /// The Price of the entree
        /// </summary>
        public double Price
        {
            get
            {
                return 6.44;
            }
        }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public uint Calories
        {
            get
            {
                return 982;
            }
        }

        /// <summary>
        /// A list of special insturctions for preparing the entree
        /// </summary>
        public List<String> SpecialInstructions
        {
            get
            {
                List<String> SpecialInstructions = new List<String>();
                return SpecialInstructions;
            }
        }


        /// <summary>
        /// Returns a description of the entree
        /// </summary>
        /// <returns> A string describing the entree</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}

