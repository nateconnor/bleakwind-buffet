/*
* Author: Nathan Connor
* Class name: Order.cs
* Purpose: Order object constructor for BleakwindBuffet
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace BleakwindBuffet.Data
{
   public class Order : ICollection<IOrderItem>, INotifyCollectionChanged, INotifyPropertyChanged
    {

        private List<IOrderItem> order;

        /// <summary>
        /// Order constructor
        /// </summary>
        public Order()
        {
            order = new List<IOrderItem>();
            thisOrderNum = nextOrderNumber;
            nextOrderNumber++;
        }

        private double _salesTax =0.12;

        /// <summary>
        /// Tax Rate of the order
        /// </summary>
        public double SalesTaxRate
        {
            get
            {
                return _salesTax;
            }

            set
            {
                _salesTax = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxRate"));
            }

        }
/// <summary>
/// Subtotal of all items prices in order
/// </summary>
        public double Subtotal {
            get
            {
                double subtotal = 0;
                foreach(IOrderItem item in order)
                {
                    subtotal += item.Price;
                }
                return subtotal;
            }
        }


        /// <summary>
        /// Subtotal multiplied by the tax rate to get tax value
        /// </summary>
        public double Tax { get { return Subtotal * SalesTaxRate; } }

        /// <summary>
        /// Total cost of the order
        /// </summary>
        public double Total { get
            {
                return Subtotal + Tax;
            }
        }
       
        /// <summary>
        /// Total calories of the order
        /// </summary>
        public uint Calories {
            get
            {
                uint cal = 0;
                foreach (IOrderItem item in order)
                {
                    cal += item.Calories;
                }
                return cal;
            }
        }//return calories sum }

        private static int nextOrderNumber = 1;
        private int thisOrderNum;

        public event PropertyChangedEventHandler PropertyChanged;
        public event NotifyCollectionChangedEventHandler CollectionChanged;


        /// <summary>
        /// Unique order number that identifies the order
        /// </summary>
        public int Number
        {
            get
            {
                return thisOrderNum;
            }
          
        }

        /// <summary>
        /// the number of items in the order
        /// </summary>
        public int Count { get { return order.Count; } }

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        /// <summary>
        /// adds a new item to the order and notifies property changes
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            order.Add(item);
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add,item));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            item.PropertyChanged += ItemChanges;
            



        }

        /// <summary>
        /// Removes an item from the order and notifies property changes
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            if (item != null)
            {
                CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item, order.IndexOf(item)));


                order.Remove(item);

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                item.PropertyChanged -= ItemChanges;

            }

        }

        /// <summary>
        /// Identifies if any items have had their properties changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemChanges(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            }
            if (e.PropertyName == "Calories") PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));


        }

        /// <summary>
        /// clears the list
        /// </summary>
        public void Clear()
        {
            order.Clear();

        }

        /// <summary>
        /// determines if an item is in the order
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(IOrderItem item)
        {
            return order.Contains(item);
        }


        /// <summary>
        /// copies an order to another one
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayIndex"></param>
        public void CopyTo(IOrderItem[] array, int arrayIndex)
        {
            order.CopyTo(array, arrayIndex);
        }

        bool ICollection<IOrderItem>.Remove(IOrderItem item)
        {
            return order.Remove(item);
        }

        public IEnumerator<IOrderItem> GetEnumerator()
        {
            return order.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return order.GetEnumerator();
        }
    }
}
