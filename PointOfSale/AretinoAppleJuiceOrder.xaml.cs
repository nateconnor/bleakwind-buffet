/*
* Author: Nathan Connor
* Class name: AretinoAppleJuiceOrder.xaml.cs
* Purpose: Controls the screen to finalize this order
*/
using BleakwindBuffet.Data.Drinks;
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
using Size =BleakwindBuffet.Data.Enums.Size;


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for AretinoAppleJuiceOrder.xaml
    /// </summary>
    public partial class AretinoAppleJuiceOrder : UserControl
    {
        OrderMenu parent;

        private AretinoAppleJuice aj;
        public AretinoAppleJuiceOrder(OrderMenu menu, AretinoAppleJuice a)
        {
            InitializeComponent();
            parent = menu;
             aj = a;
            DataContext = aj;

        }

        /// <summary>
        /// Returns to the full menu screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backToScreen(object sender, RoutedEventArgs e)
        {
           // Order o = (Order)parent.DataContext;
           // //AretinoAppleJuiceOrder bbo = this;
           //// parent.menuBorder.Child = bbo;
           // o.Add((IOrderItem)this.DataContext);
            parent.menuBorder.Child = new MenuSelection(parent);

        }

        /// <summary>
        /// Changes the size of the current menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SizeChanges(object sender, RoutedEventArgs e)
        {
            if ((bool) uxSmall.IsChecked)
            {
                aj.Size = Size.Small;
            }
            else if ((bool)uxMedium.IsChecked)
            {
                aj.Size = Size.Medium;
            }
            else if ((bool)uxLarge.IsChecked)
                aj.Size = Size.Large;
        }
    }
}
