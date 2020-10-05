/*
* Author: Nathan Connor
* Class name: GardenOrcOmelette.cs
* Purpose: Entree object constructor for BleakwindBuffet
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for representing Garden Orc Omelette
    /// </summary>
    public class GardenOrcOmelette : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The Price of the entree
        /// </summary>
        public override double Price
        {
            get
            {
                return 4.57;
            }
        }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 404;
            }
        }

        /// <summary>
        /// A list of special insturctions for preparing the entree
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get {
                List<String> SpecialInstructions = new List<String>();

                if (!Broccoli)
                {
                    SpecialInstructions.Add("Hold Broccoli");
                }
                if (!Mushrooms)
                {
                    SpecialInstructions.Add("Hold Mushrooms");
                }
                if (!Tomato)
                {
                    SpecialInstructions.Add("Hold Tomato");
                }
                if (!Cheddar)
                {
                    SpecialInstructions.Add("Hold Cheddar");
                }
                
                return SpecialInstructions;
            }

        }

        private bool _broccoli = true;
        private bool _mushrooms = true;

        private bool _tomato = true;
        private bool _cheddar = true;


        /// <summary>
        /// Whether or not the entree has Broccoli
        /// </summary>
        public bool Broccoli
        {
            get => _broccoli;
            set
            {
                _broccoli = value;
                InvokePropertyChanged("Broccoli");
            }

        }
        /// <summary>
        /// Whether or not the entree has Mushrooms
        /// </summary>
        public bool Mushrooms
        {
            get => _mushrooms;
            set
            {
                _mushrooms = value;
                InvokePropertyChanged("Mushrooms");
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
            }

        }
        /// <summary>
        /// Whether or not the entree has Cheddar
        /// </summary>
        public bool Cheddar
        {
            get => _cheddar;
            set
            {
                _cheddar = value;
                InvokePropertyChanged("Cheddar");
            }

        }


        /// <summary>
        /// Returns a description of the entree
        /// </summary>
        /// <returns> A string describing the entree</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
