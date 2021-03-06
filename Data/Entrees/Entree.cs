﻿/*
* Author: Nathan Connor
* Class name: Entree.cs
* Purpose: Entree object constructor for BleakwindBuffet
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;


namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A base class to represent all Entrees
    /// </summary>
    public abstract class Entree : IOrderItem, INotifyPropertyChanged
    {
        public virtual string Type => "Entree";
        /// <summary>
        /// The price of the entree
        /// </summary>
        /// <value> In US Dollars</value>
        public abstract double Price { get; }

        /// <summary>
        /// Description of the entree
        /// </summary>
        public abstract string Description { get; }

        public virtual string FullString
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// The amount of calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special Instructions to prepare the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        public virtual event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Invokes the property changed
        /// </summary>
        /// <param name="property"></param>
        protected void InvokePropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
