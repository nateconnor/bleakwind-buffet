/*
* Author: Nathan Connor
* Class name: ThalmorTripleOrder.xaml.cs
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
using BleakwindBuffet.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ThalmorTripleOrder.xaml
    /// </summary>
    public partial class ThalmorTripleOrder : UserControl
    {
        OrderMenu parent;
        //private ThalmorTriple tt = new ThalmorTriple();
        public ThalmorTripleOrder(OrderMenu p, ThalmorTriple tt)
        {
            InitializeComponent();
            parent = p;
            DataContext = tt;
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
