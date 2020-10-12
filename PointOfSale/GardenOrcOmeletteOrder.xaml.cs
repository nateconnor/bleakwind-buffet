/*
* Author: Nathan Connor
* Class name: GardenOrcOmelette.xaml.cs
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
    /// Interaction logic for GardenOrcOmeletteOrder.xaml
    /// </summary>
    public partial class GardenOrcOmeletteOrder : UserControl
    {
        OrderMenu parent;
        //private GardenOrcOmelette orc = new GardenOrcOmelette();
        public GardenOrcOmeletteOrder(OrderMenu p, GardenOrcOmelette orc)
        {
            InitializeComponent();
            parent = p;
            DataContext = orc;
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
    }
}
