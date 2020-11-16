/*
* Author: Nathan Connor
* Class name: SmokehouseSkeleton.cs
* Purpose: Entree object constructor for BleakwindBuffet
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for representing Smokehouse Skeleton
    /// </summary>
    public class SmokehouseSkeleton : Entree, IOrderItem
    {
        /// <summary>
        /// The Price of the entree
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.62;
            }
        }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 602;
            }
        }

        /// <summary>
        /// Description of the food item
        /// </summary>
        public override string Description
        {
            get
            {
                return "Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.";
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

                if (!SausageLink)
                {
                    SpecialInstructions.Add("Hold sausage");
                }
                if (!Egg)
                {
                    SpecialInstructions.Add("Hold eggs");
                }
                if (!HashBrowns)
                {
                    SpecialInstructions.Add("Hold hash browns");
                }
                if (!Pancake)
                {
                    SpecialInstructions.Add("Hold pancakes");
                }
                
                return SpecialInstructions;
            }

        }
        private bool _sausage = true;
        private bool _egg = true;

        private bool _hash = true;

        private bool _pancake = true;

        /// <summary>
        /// Whether or not the entree has SausageLink
        /// </summary>
        public bool SausageLink
        {
            get => _sausage;
            set
            {
                _sausage = value;
                InvokePropertyChanged("SausageLink");
                InvokePropertyChanged("SpecialInstructions");

            }

        }
        /// <summary>
        /// Whether or not the entree has Egg
        /// </summary>
        public bool Egg
        {
            get => _egg;
            set
            {
                _egg = value;
                InvokePropertyChanged("Egg");
                InvokePropertyChanged("SpecialInstructions");

            }

        }
        /// <summary>
        /// Whether or not the entree has HashBrowns
        /// </summary>
        public bool HashBrowns
        {
            get => _hash;
            set
            {
                _hash = value;
                InvokePropertyChanged("HashBrowns");
                InvokePropertyChanged("SpecialInstructions");

            }

        }
        /// <summary>
        /// Whether or not the entree has Pancake
        /// </summary>
        public bool Pancake
        {
            get => _pancake;
            set
            {
                _pancake = value;
                InvokePropertyChanged("Pancake");
                InvokePropertyChanged("SpecialInstructions");

            }

        }


        /// <summary>
        /// Returns a description of the entree
        /// </summary>
        /// <returns> A string describing the entree</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
