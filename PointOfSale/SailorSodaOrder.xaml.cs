using System;
using System.Collections.Generic;
using System.Text;
/*
* Author: Nathan Connor
* Class name: SailorSodaOrder.xaml.cs
* Purpose: Controls the screen to finalize this order
*/
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
    /// Interaction logic for SailorSodaOrder.xaml
    /// </summary>
    public partial class SailorSodaOrder : UserControl
    {
        Order parent;

        public SailorSodaOrder(Order menu)
        {
            InitializeComponent();
            parent = menu;

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
