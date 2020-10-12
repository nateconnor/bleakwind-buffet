/*
* Author: Nathan Connor
* Class name: Order.xaml.cs
* Purpose: Controls the price and total items ordered in GUI
*/
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for Order.xaml
    /// </summary>
    public partial class OrderMenu : UserControl
    {
        private Order _order;
        public OrderMenu()
        {
            InitializeComponent();
            menuBorder.Child = new MenuSelection(this);
            _order = new Order();
            DataContext = _order;

        }

        /// <summary>
        /// Deletes the selected item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            IOrderItem item = (IOrderItem) orderList.SelectedItem;
            _order.Remove(item);
            menuBorder.Child = new MenuSelection(this);

        }

        /// <summary>
        /// Edits the item that is clicked on
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            IOrderItem item = (IOrderItem)orderList.SelectedItem;
            if (item is BriarheartBurger) menuBorder.Child = new BriarheartBurgerOrder(this, (BriarheartBurger)item);
            else if (item is DoubleDraugr) menuBorder.Child = new DoubleDraugrOrder(this, (DoubleDraugr)item);
            else if (item is GardenOrcOmelette) menuBorder.Child = new GardenOrcOmeletteOrder(this, (GardenOrcOmelette)item);
            else if (item is PhillyPoacher) menuBorder.Child = new PhillyPoacherOrder(this, (PhillyPoacher)item);
            else if (item is SmokehouseSkeleton) menuBorder.Child = new SmokehouseSkeletonOrder(this, (SmokehouseSkeleton)item);
            else if (item is ThalmorTriple) menuBorder.Child = new ThalmorTripleOrder(this, (ThalmorTriple)item);
            else if (item is ThugsTBone) ;


            else if (item is AretinoAppleJuice) menuBorder.Child = new AretinoAppleJuiceOrder(this, (AretinoAppleJuice)item);
            else if (item is CandlehearthCoffee) menuBorder.Child = new CandlehearthCoffeeOrder(this, (CandlehearthCoffee)item);
            else if (item is MarkarthMilk) menuBorder.Child = new MarkarthMilkOrder(this, (MarkarthMilk)item);
            else if (item is SailorSoda) menuBorder.Child = new SailorSodaOrder(this, (SailorSoda)item);
            else if (item is WarriorWater) menuBorder.Child = new WarriorWaterOrder(this, (WarriorWater)item);

            else if (item is DragonbornWaffleFries ) menuBorder.Child = new DragonbornWaffleFriesOrder(this, (DragonbornWaffleFries)item);
            else if (item is FriedMiraak) menuBorder.Child = new FriedMiraakOrder(this, (FriedMiraak)item);
            else if (item is MadOtarGrits) menuBorder.Child = new MadOtarGritsOrder(this, (MadOtarGrits)item);
            else if (item is VokunSalad) menuBorder.Child = new VokunSaladOrder(this, (VokunSalad)item);



            // _order.Remove(item);
        }


        /// <summary>
        /// Finishes the order and creates a new one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Finish_Click(object sender, RoutedEventArgs e)
        {
            _order = new Order();
            DataContext = _order;
            menuBorder.Child = new MenuSelection(this);

        }

    }
}
