﻿/*
* Author: Nathan Connor
* Class name: FriedMiraak.xaml.cs
* Purpose: Controls the screen to finalize this order
*/
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Size = BleakwindBuffet.Data.Enums.Size;


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for FriedMiraak.xaml
    /// </summary>
    public partial class FriedMiraakOrder : UserControl
    {
        OrderMenu parent;

        private FriedMiraak fm;
        public FriedMiraakOrder(OrderMenu menu, FriedMiraak f)
        {
            InitializeComponent();
            parent = menu;
            fm = f;
            DataContext = fm;

        }

        /// <summary>
        /// Returns to the full menu screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backToScreen(object sender, RoutedEventArgs e)
        {
            //Order o = (Order)parent.DataContext;

            //o.Add((IOrderItem)this.DataContext);
            parent.menuBorder.Child = new MenuSelection(parent);
            //parent.menuBorder.Child = new MenuSelection(parent);

        }

        void SizeChanges(object sender, RoutedEventArgs e)
        {
            if ((bool)uxSmall.IsChecked)
            {
                fm.Size = Size.Small;
            }
            else if ((bool)uxMedium.IsChecked)
            {
                fm.Size = Size.Medium;
            }
            else if ((bool)uxLarge.IsChecked)
                fm.Size = Size.Large;
        }
    }
}
