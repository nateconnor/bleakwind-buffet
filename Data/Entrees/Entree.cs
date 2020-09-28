/*
* Author: Nathan Connor
* Class name: Entree.cs
* Purpose: Entree object constructor for BleakwindBuffet
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A base class to represent all Entrees
    /// </summary>
    public abstract class Entree : IOrderItem
    {

        /// <summary>
        /// The price of the entree
        /// </summary>
        /// <value> In US Dollars</value>
        public abstract double Price { get; }

        /// <summary>
        /// The amount of calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special Instructions to prepare the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
