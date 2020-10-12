/*
* Author: Nathan Connor
* Class name: Drink.cs
* Purpose: Drink object constructor for BleakwindBuffet
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;



namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing common properties of drinks
    /// </summary>
   public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {
        protected Size size = Size.Small;

        /// <summary>
        /// The size of the drink
        /// </summary>
        public virtual Size Size 
        { 
            get => size; 
            set 
            {
                size = value;
                InvokePropertyChanged("Size");
                InvokePropertyChanged("Price");
                InvokePropertyChanged("Calories");
                InvokePropertyChanged("FullString");




            }
        }

        public virtual string FullString
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// The price of the drink
        /// </summary>
        /// <value> In US Dollars</value>
        public abstract double Price { get;  }

        /// <summary>
        /// The amount of calories of the drink
        /// </summary>
        public abstract uint Calories { get;  }

        /// <summary>
        /// Special Instructions to prepare the drink
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
