/*
* Author: Nathan Connor
* Class name: ThalmorTripleOrder.xaml.cs
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
using BleakwindBuffet.Data;


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for VokunSaladOrder.xaml
    /// </summary>
    public partial class VokunSaladOrder : UserControl
    {
        OrderMenu parent;

        private VokunSalad vokun;
        public VokunSaladOrder(OrderMenu menu, VokunSalad vok)
        {
            InitializeComponent();
            parent = menu;
            vokun = vok;
            DataContext = vokun;

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
           // parent.menuBorder.Child = new MenuSelection(parent);

        }

        void SizeChanges(object sender, RoutedEventArgs e)
        {
            if ((bool)uxSmall.IsChecked)
            {
                vokun.Size = Size.Small;
            }
            else if ((bool)uxMedium.IsChecked)
            {
                vokun.Size = Size.Medium;
            }
            else if ((bool)uxLarge.IsChecked)
                vokun.Size = Size.Large;
        }
    }
}
