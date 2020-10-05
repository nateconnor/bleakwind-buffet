﻿/*
* Author: Nathan Connor
* Class name: SmokehouseSkeleton.xaml.cs
* Purpose: Controls the screen to finalize this order
*/
using BleakwindBuffet.Data.Entrees;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SmokehouseSkeleton.xaml
    /// </summary>
    public partial class SmokehouseSkeletonOrder : UserControl
    {
        Order parent;
        private SmokehouseSkeleton ss = new SmokehouseSkeleton();

        public SmokehouseSkeletonOrder(Order menu)
        {
            InitializeComponent();
            parent = menu;
            DataContext = ss;

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
    }
}