/*
* Author: Nathan Connor
* Class name: MarkarthMilk.xaml.cs
* Purpose: Controls the screen to finalize this order
*/
using BleakwindBuffet.Data.Drinks;
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
using BleakwindBuffet.Data;


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MarkarthMilkOrder.xaml
    /// </summary>
    public partial class MarkarthMilkOrder : UserControl
    {
        OrderMenu parent;
        private MarkarthMilk mm;
        public MarkarthMilkOrder(OrderMenu menu, MarkarthMilk m)
        {
            InitializeComponent();
            parent = menu;
            mm = m;
            DataContext = mm;

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
                mm.Size = Size.Small;
            }
            else if ((bool)uxMedium.IsChecked)
            {
                mm.Size = Size.Medium;
            }
            else if ((bool)uxLarge.IsChecked)
                mm.Size = Size.Large;
        }
    }
}
