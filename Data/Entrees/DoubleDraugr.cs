﻿/*
* Author: Nathan Connor
* Class name: DoubleDraugr.cs
* Purpose: Entree object constructor for BleakwindBuffet
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for representing Double Draugr
    /// </summary>
    public class DoubleDraugr : Entree, IOrderItem
    {
        /// <summary>
        /// The Price of the entree
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.32;
            }
        }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 843;
            }
        }

        /// <summary>
        /// A list of special insturctions for preparing the entree
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<String> SpecialInstructions = new List<String>();

                if (!Bun)
                {
                    SpecialInstructions.Add("Hold Bun");
                }
                if (!Ketchup)
                {
                    SpecialInstructions.Add("Hold Ketchup");
                }
                if (!Mustard)
                {
                    SpecialInstructions.Add("Hold Mustard");
                }
                if (!Pickle)
                {
                    SpecialInstructions.Add("Hold Pickle");
                }
                if (!Cheese)
                {
                    SpecialInstructions.Add("Hold Cheese");
                }
                if (!Tomato)
                {
                    SpecialInstructions.Add("Hold Tomato");
                }
                if (!Lettuce)
                {
                    SpecialInstructions.Add("Hold Lettuce");
                }
                if (!Mayo)
                {
                    SpecialInstructions.Add("Hold Mayo");
                }
                return SpecialInstructions;
            }

        }

        /// <summary>
        /// Description of the food item
        /// </summary>
        public override string Description
        {
            get
            {
                return "Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.";
            }
        }

        private bool _bun = true;
        private bool _ketchup = true;

        private bool _mustard = true;

        private bool _pickle = true;

        private bool _cheese = true;
        private bool _tomato = true;
        private bool _lettuce = true;
        private bool _mayo = true;

        /// <summary>
        /// Whether or not the entree has bun
        /// </summary>
        public bool Bun
        {
            get => _bun;
            set
            {
                _bun = value;
                InvokePropertyChanged("Bun");
                InvokePropertyChanged("SpecialInstructions");

            }

        }
        /// <summary>
        /// Whether or not the entree has ketchup
        /// </summary>
        public bool Ketchup
        {
            get => _ketchup;
            set
            {
                _ketchup = value;
                InvokePropertyChanged("Ketchup");
                InvokePropertyChanged("SpecialInstructions");

            }

        }
        /// <summary>
        /// Whether or not the entree has mustard
        /// </summary>
        public bool Mustard
        {
            get => _mustard;
            set
            {
                _mustard = value;
                InvokePropertyChanged("Mustard");
                InvokePropertyChanged("SpecialInstructions");

            }

        }
        /// <summary>
        /// Whether or not the entree has Pickle
        /// </summary>
        public bool Pickle
        {
            get => _pickle;
            set
            {
                _pickle = value;
                InvokePropertyChanged("Pickle");
                InvokePropertyChanged("SpecialInstructions");

            }

        }
        /// <summary>
        /// Whether or not the entree has Cheese
        /// </summary>
        public bool Cheese
        {
            get => _cheese;
            set
            {
                _cheese = value;
                InvokePropertyChanged("Cheese");
                InvokePropertyChanged("SpecialInstructions");

            }

        }
        /// <summary>
        /// Whether or not the entree has Tomato
        /// </summary>
        public bool Tomato
        {
            get => _tomato;
            set
            {
                _tomato = value;
                InvokePropertyChanged("Tomato");
                InvokePropertyChanged("SpecialInstructions");

            }

        }
        /// <summary>
        /// Whether or not the entree has Lettuce
        /// </summary>
        public bool Lettuce
        {
            get => _lettuce;
            set
            {
                _lettuce = value;
                InvokePropertyChanged("Lettuce");
                InvokePropertyChanged("SpecialInstructions");

            }

        }
        /// <summary>
        /// Whether or not the entree has Mayo
        /// </summary>
        public bool Mayo
        {
            get => _mayo;
            set
            {
                _mayo = value;
                InvokePropertyChanged("Mayo");
                InvokePropertyChanged("SpecialInstructions");

            }

        }


        /// <summary>
        /// Returns a description of the entree
        /// </summary>
        /// <returns> A string describing the entree</returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
