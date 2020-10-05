
/*
* Author: Nathan Connor
* Class name: BriarheartBurger.cs
* Purpose: Entree object constructor for BleakwindBuffet
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for representing Briarheart Burger
    /// </summary>
    public class BriarheartBurger : Entree, IOrderItem
    {
        /// <summary>
        /// The Price of the entree
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.32;
            }
        }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 743;
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
                return SpecialInstructions;
            }

        }

        private bool _bun = true;
        private bool _ketchup = true;

        private bool _mustard = true;

        private bool _pickle = true;

        private bool _cheese = true;

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
            }

        }



        /// <summary>
        /// Returns a description of the entree
        /// </summary>
        /// <returns> A string describing the entree</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }


    }
}
