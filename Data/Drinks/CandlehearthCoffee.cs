/*
* Author: Nathan Connor
* Class name: CandlehearthCoffee.cs
* Purpose: Drink object constructor for BleakwindBuffet
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class for representing Candlehearth Coffee
    /// </summary>
    public class CandlehearthCoffee : Drink, IOrderItem
    {
        /// <summary>
        /// The Price of the drink
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                    return .75;
                else if (Size == Size.Medium)
                    return 1.25;
                else
                    return 1.75;


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
                    return 7;
                else if (Size == Size.Medium)
                    return 10;
                else
                    return 20;

            }
        }

       


        /// <summary>
        /// Whether or not the drink has ice
        /// </summary>
        public bool Ice { get; set; } = false;
        /// <summary>
        /// Whether or not the drink has cream
        /// </summary>
        public bool  RoomForCream { get; set; } = false;
        /// <summary>
        /// Whether or not the drink is decaf
        /// </summary>
        public bool  Decaf { get; set; }  = false;

        /// <summary>
        /// A list of special insturctions for preparing the drink
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<String> SpecialInstructions = new List<string>();

                if (Ice)
                {
                    SpecialInstructions.Add("Add ice");
                }
                if (RoomForCream)
                {
                    SpecialInstructions.Add("Add cream");
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
            if(!Decaf)
            return $"{Size} Candlehearth Coffee";
            else
                return $"{Size} Decaf Candlehearth Coffee";

        }
    }
}

