/*
* Author: Nathan Connor
* Class name: Side.cs
* Purpose: Side object constructor for BleakwindBuffet
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A base class representing common properties of side
    /// </summary>
    public abstract class Side: IOrderItem, INotifyPropertyChanged
    {
        protected Size size = Size.Small;

        /// <summary>
        /// The size of the side
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
        /// The price of the side
        /// </summary>
        /// <value> In US Dollars</value>
        public abstract double Price { get; }

        /// <summary>
        /// The amount of calories of the side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special Instructions to prepare the side
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        public event PropertyChangedEventHandler PropertyChanged;

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
