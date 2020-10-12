/*
* Author: Nathan Connor
* Class name: AretinoAppleJuice.cs
* Purpose: Drink object constructor for BleakwindBuffet
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class for representing Aretino Apple Juice
    /// </summary>
    public class AretinoAppleJuice :  Drink, IOrderItem
    {

        //public override Size Size
        //{
        //    get => size;
        //    set
        //    {
        //        size = value;
        //        InvokePropertyChanged("Size");
        //        InvokePropertyChanged("Price");
        //        InvokePropertyChanged("Calories");



        //    }
        //}

        /// <summary>
        /// The Price of the drink
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                    return .62;
                else if (Size == Size.Medium)
                    return .87;
                else
                    return 1.01;


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
                    return 44;
                else if (Size == Size.Medium)
                    return 88;
                else
                    return 132;

            }
        }



        private bool _ice = false;
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
                InvokePropertyChanged("SpecialInstructions");

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

                if (Ice)
                {
                    SpecialInstructions.Add("Add ice");
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
            return $"{Size} Aretino Apple Juice";
        }

        
    }
}

