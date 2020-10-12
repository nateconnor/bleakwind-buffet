/*
* Author: Nathan Connor
* Class name: WarriorWaterOrder.xaml.cs
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
    /// Interaction logic for WarriorWaterOrder.xaml
    /// </summary>
    public partial class WarriorWaterOrder : UserControl
    {
        OrderMenu parent;
        private WarriorWater ww;
        public WarriorWaterOrder(OrderMenu menu, WarriorWater water)
        {
            InitializeComponent();
            parent = menu;
            ww = water;
            DataContext = ww;

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
                ww.Size = Size.Small;
            }
            else if ((bool)uxMedium.IsChecked)
            {
                ww.Size = Size.Medium;
            }
            else if ((bool)uxLarge.IsChecked)
                ww.Size = Size.Large;
        }
    }
}
