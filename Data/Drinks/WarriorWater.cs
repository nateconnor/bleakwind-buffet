/*
* Author: Nathan Connor
* Class name: WarriorWater.cs
* Purpose: Drink object constructor for BleakwindBuffet
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class for representing WarriorWater
    /// </summary>
    public class WarriorWater : Drink, IOrderItem
    {
        /// <summary>
        /// The Price of the drink
        /// </summary>
        public override double Price
        {
            get
            {
                return 0;
            }
        }

        /// <summary>
        /// The calories of the drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 0;
            }
        }



        private bool _ice = true;
        private bool _lemon = false;


        /// <summary>
        /// Whether or not the drink has ice
        /// </summary>
        public bool Ice
        {
            get => _ice;
            set
            {
                _ice = value;
                InvokePropertyChanged("Ice");
            }

        }
        /// <summary>
        /// Whether or not the drink has lemon
        /// </summary>
        public bool Lemon
        {
            get => _lemon;
            set
            {
                _lemon = value;
                InvokePropertyChanged("Lemon");
            }

        }

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
                if (Lemon)
                {
                    SpecialInstructions.Add("Add lemon");
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
            return $"{Size} Warrior Water";
        }
    }
}

