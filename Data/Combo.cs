/*
* Author: Nathan Connor
* Class name: Combo.cs
* Purpose: Combo object constructor for BleakwindBuffet
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;

using BleakwindBuffet.Data.Sides;
using System.ComponentModel;

namespace BleakwindBuffet.Data
{
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        private List<IOrderItem> _combo;

        /// <summary>
        /// Constructor for combo
        /// </summary>
        public Combo()
        {
            _combo = new List<IOrderItem>();
        }

        private Drink _drink;

        /// <summary>
        /// drink property that holds a drink item
        /// </summary>
        public Drink drink
        {
            get
            {
                return _drink;
            }
            set
            {
                if (_drink != null) _drink.PropertyChanged -= ItemChanges;


                _drink = value;
                _drink.PropertyChanged += ItemChanges;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));



            }
        }

        private Entree _entree;

        /// <summary>
        /// entree property that holds an entree item
        /// </summary>
        public Entree entree
        {
            get
            {
                return _entree;
            }
            set
            {
                if (_entree != null)
                {
                    _entree.PropertyChanged -= ItemChanges;
                }
                

                _entree = value;
                _entree.PropertyChanged += ItemChanges;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));



            }
        }

        private Side _side;

        /// <summary>
        /// Side property that can get and set side
        /// </summary>
        public Side side
        {
            get
            {
                return _side;
            }
            set
            {
                if (_side != null) _side.PropertyChanged -= ItemChanges;

                _side = value;
                _side.PropertyChanged += ItemChanges;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));



            }
        }

        /// <summary>
        /// Price of the total combo
        /// </summary>
        public double Price
        {
            get
            {
                
                return _drink.Price+_entree.Price+_side.Price-1;
            }
        }

        /// <summary>
        /// Total Calories of the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                return _drink.Calories + _entree.Calories + _side.Calories;

            }
        }

        /// <summary>
        /// Special Instructions of the total combo
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> list = new List<string>();
                list.Add(_entree.ToString());
                list.AddRange(_entree.SpecialInstructions);
                list.Add(_drink.ToString());
                    list.AddRange(_drink.SpecialInstructions);
                list.Add(_side.ToString());
                list.AddRange(_side.SpecialInstructions);

                return list;
            }
        }

        /// <summary>
        /// Sends property events if the proprties of the combo change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemChanges(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                
            }
            if (e.PropertyName == "Calories") PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            if(e.PropertyName== "SpecialInstructions") PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));


        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
