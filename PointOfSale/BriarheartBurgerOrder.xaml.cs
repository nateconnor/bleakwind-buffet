﻿/*
* Author: Nathan Connor
* Class name: BriarheartBurgerOrder.xaml.cs
* Purpose: Controls the screen to finalize this order
*/
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
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;


namespace PointOfSale
{
    
    /// <summary>
    /// Interaction logic for BriarheartBurgerOrder.xaml
    /// </summary>
    public partial class BriarheartBurgerOrder : UserControl
    {
        //private BriarheartBurger burger = new BriarheartBurger();
        OrderMenu parent;

        public BriarheartBurgerOrder(OrderMenu menu, BriarheartBurger burger)
        {
            InitializeComponent();
            parent = menu;
            DataContext = burger;
            
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
           


            

        }
    }
}
