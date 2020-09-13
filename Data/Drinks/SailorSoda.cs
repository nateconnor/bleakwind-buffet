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
    /// <summary>
    /// Class for representing Sailor Soda
    /// </summary>
    public class SailorSoda : Drink, IOrderItem
    {
        /// <summary>
        /// The Price of the drink
        /// </summary>
        public override double Price
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

        /// <summary>
        /// The calories of the drink
        /// </summary>
        public override uint Calories
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

        

        /// <summary>
        /// The flavor of the drink
        /// </summary>
        public SodaFlavor Flavor
        {
            get; set;
        } = SodaFlavor.Cherry;

        /// <summary>
        /// Whether or not the drink has ice
        /// </summary>
        public bool Ice { get; set; } =  true;

        /// <summary>
        /// A list of special insturctions for preparing the drink
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<String> SpecialInstructions = new List<string>();

                if (!Ice)
                {
                    SpecialInstructions.Add("Hold ice");
                }
                return SpecialInstructions;
            }
        }


        /// <summary>
        /// Returns a description of the drink
        /// </summary>
        /// <returns> A string describing the drink</returns>
        public override string ToString()
        {
            return $"{Size} {Flavor} Sailor Soda";
        }
    }
}
