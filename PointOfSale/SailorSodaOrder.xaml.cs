using BleakwindBuffet.Data.Drinks;
using System;
using System.Collections.Generic;
using System.Text;
using Size = BleakwindBuffet.Data.Enums.Size;

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
using BleakwindBuffet.Data.Enums;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SailorSodaOrder.xaml
    /// </summary>
    public partial class SailorSodaOrder : UserControl
    {
        Order parent;
        private SailorSoda soda = new SailorSoda();
        public SailorSodaOrder(Order menu)
        {
            InitializeComponent();
            parent = menu;
            DataContext = soda;

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
                soda.Size = Size.Small;
            }
            else if ((bool)uxMedium.IsChecked)
            {
                soda.Size = Size.Medium;
            }
            else if ((bool)uxLarge.IsChecked)
                soda.Size = Size.Large;
        }

        void FlavorChanges(object sender, RoutedEventArgs e)
        {
            if ((bool)uxBlackberry.IsChecked)
            {
                soda.Flavor = SodaFlavor.Blackberry;
            }
            else if ((bool)uxCherry.IsChecked)
            {
                soda.Flavor = SodaFlavor.Cherry;
            }
            else if ((bool)uxGrapefruit.IsChecked)
            {
                soda.Flavor = SodaFlavor.Grapefruit;
            }
            else if ((bool)uxLemon.IsChecked)
            {
                soda.Flavor = SodaFlavor.Lemon;
            }
            else if ((bool)uxPeach.IsChecked)
            {
                soda.Flavor = SodaFlavor.Peach;
            }
            else if ((bool)uxWatermelon.IsChecked)
            {
                soda.Flavor = SodaFlavor.Watermelon;
            }
        }
    }
}
