/*
 * Author: Nathan Connor
 * Class: IOrderItem.cs
 * Purpose: An interface for all menu objects
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// An interface that allows drinks, sides, and entrees to be ordered
    /// </summary>
   public interface IOrderItem : INotifyPropertyChanged
    {
        string Type { get; }

        double Price { get; }

        uint Calories { get; }

        List<string> SpecialInstructions { get; }
    }
}
