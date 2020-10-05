﻿/*
* Author: Nathan Connor
* Class name: DragonbornWaffleFries.xaml.cs
* Purpose: Controls the screen to finalize this order
*/
using BleakwindBuffet.Data.Sides;
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
    /// Interaction logic for DragonbornWaffleFriesOrder.xaml
    /// </summary>
    public partial class DragonbornWaffleFriesOrder : UserControl
    {
        Order parent;
        private DragonbornWaffleFries dw = new DragonbornWaffleFries();
        public DragonbornWaffleFriesOrder(Order menu)
        {
            InitializeComponent();
            parent = menu;
            DataContext = dw;
        }

        /// <summary>
        /// Returns to the full menu screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backToScreen(object sender, RoutedEventArgs e)
        {
            parent.menuBorder.Child = new MenuSelection(parent);

        }

        void SizeChanges(object sender, RoutedEventArgs e)
        {
            if ((bool)uxSmall.IsChecked)
            {
                dw.Size = Size.Small;
            }
            else if ((bool)uxMedium.IsChecked)
            {
                dw.Size = Size.Medium;
            }
            else if ((bool)uxLarge.IsChecked)
                dw.Size = Size.Large;
        }
    }
}