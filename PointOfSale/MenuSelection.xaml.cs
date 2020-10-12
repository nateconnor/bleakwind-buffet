/*
* Author: Nathan Connor
* Class name: MenuSelection.xaml.cs
* Purpose: Controls the buttons for every menu item in GUI
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
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class MenuSelection : UserControl
    {
        OrderMenu parent;
        public MenuSelection(OrderMenu p)
        {
            InitializeComponent();
            parent = p;
        }

        /// <summary>
        /// Sends the user to the Order Specifics for this menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BriarheartBurgerClick(object sender, RoutedEventArgs e)
        {
            BriarheartBurgerOrder item = new BriarheartBurgerOrder(parent, new BriarheartBurger());
            parent.menuBorder.Child = item;
            Order o = (Order)parent.DataContext;

            o.Add((IOrderItem)item.DataContext);
            //parent.menuBorder.Child = new MenuSelection(parent);

        }

        /// <summary>
        /// Sends the user to the Order Specifics for this menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoubleDraugrClick(object sender, RoutedEventArgs e)
        {
           DoubleDraugrOrder item = new DoubleDraugrOrder(parent, new DoubleDraugr());
            parent.menuBorder.Child = item;
            Order o = (Order)parent.DataContext;

            o.Add((IOrderItem)item.DataContext);

        }

        /// <summary>
        /// Sends the user to the Order Specifics for this menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GardenOrcOmeletteClick(object sender, RoutedEventArgs e)
        {

            GardenOrcOmeletteOrder item = new GardenOrcOmeletteOrder(parent, new GardenOrcOmelette());
            parent.menuBorder.Child = item;
            Order o = (Order)parent.DataContext;

            o.Add((IOrderItem)item.DataContext);

        }

        /// <summary>
        /// Sends the user to the Order Specifics for this menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhillyPoacherClick(object sender, RoutedEventArgs e)
        {

            PhillyPoacherOrder item = new PhillyPoacherOrder(parent, new PhillyPoacher());
            parent.menuBorder.Child = item;
            Order o = (Order)parent.DataContext;

            o.Add((IOrderItem)item.DataContext);

        }

        /// <summary>
        /// Sends the user to the Order Specifics for this menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SmokehouseSkeletonClick(object sender, RoutedEventArgs e)
        {

            SmokehouseSkeletonOrder item = new SmokehouseSkeletonOrder(parent, new SmokehouseSkeleton());
            parent.menuBorder.Child = item;
            Order o = (Order)parent.DataContext;

            o.Add((IOrderItem)item.DataContext);

        }

        /// <summary>
        /// Sends the user to the Order Specifics for this menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThalmorTripleClick(object sender, RoutedEventArgs e)
        {

            ThalmorTripleOrder item = new ThalmorTripleOrder(parent, new ThalmorTriple());
            parent.menuBorder.Child = item;
            Order o = (Order)parent.DataContext;

            o.Add((IOrderItem)item.DataContext);

        }

        /// <summary>
        /// Sends the user to the Order Specifics for this menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThugsTBoneClick(object sender, RoutedEventArgs e)
        {

            //DoubleDraugrOrder item = new DoubleDraugrOrder(parent, new DoubleDraugr());
            //parent.menuBorder.Child = item;
            Order o = (Order)parent.DataContext;

            o.Add(new ThugsTBone());

        }

        /// <summary>
        /// Sends the user to the Order Specifics for this menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AretinoAppleJuiceClick(object sender, RoutedEventArgs e)
        {

            AretinoAppleJuiceOrder item = new AretinoAppleJuiceOrder(parent, new AretinoAppleJuice());
            parent.menuBorder.Child = item;
            Order o = (Order)parent.DataContext;

            o.Add((IOrderItem)item.DataContext);

            //parent.menuBorder.Child = new AretinoAppleJuiceOrder(parent);
            

        }

        /// <summary>
        /// Sends the user to the Order Specifics for this menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CandlehearthCoffeeClick(object sender, RoutedEventArgs e)
        {

            CandlehearthCoffeeOrder item = new CandlehearthCoffeeOrder(parent, new CandlehearthCoffee());
            parent.menuBorder.Child = item;
            Order o = (Order)parent.DataContext;

            o.Add((IOrderItem)item.DataContext);
        }

        /// <summary>
        /// Sends the user to the Order Specifics for this menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MarkarthMilkClick(object sender, RoutedEventArgs e)
        {

            MarkarthMilkOrder item = new MarkarthMilkOrder(parent, new MarkarthMilk());
            parent.menuBorder.Child = item;
            Order o = (Order)parent.DataContext;

            o.Add((IOrderItem)item.DataContext);
        }

        /// <summary>
        /// Sends the user to the Order Specifics for this menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WarriorWaterClick(object sender, RoutedEventArgs e)
        {

            WarriorWaterOrder item = new WarriorWaterOrder(parent, new WarriorWater());
            parent.menuBorder.Child = item;
            Order o = (Order)parent.DataContext;

            o.Add((IOrderItem)item.DataContext);
        }

        /// <summary>
        /// Sends the user to the Order Specifics for this menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SailorSodaClick(object sender, RoutedEventArgs e)
        {

            SailorSodaOrder item = new SailorSodaOrder(parent, new SailorSoda());
            parent.menuBorder.Child = item;
            Order o = (Order)parent.DataContext;

            o.Add((IOrderItem)item.DataContext);
        }

        /// <summary>
        /// Sends the user to the Order Specifics for this menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DragonbornWaffleFriesClick(object sender, RoutedEventArgs e)
        {

            DragonbornWaffleFriesOrder item = new DragonbornWaffleFriesOrder(parent, new DragonbornWaffleFries());
            parent.menuBorder.Child = item;
            Order o = (Order)parent.DataContext;

            o.Add((IOrderItem)item.DataContext);
        }

        /// <summary>
        /// Sends the user to the Order Specifics for this menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FriedMiraakClick(object sender, RoutedEventArgs e)
        {

            FriedMiraakOrder item = new FriedMiraakOrder(parent, new FriedMiraak());
            parent.menuBorder.Child = item;
            Order o = (Order)parent.DataContext;

            o.Add((IOrderItem)item.DataContext);

        }

        /// <summary>
        /// Sends the user to the Order Specifics for this menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MadOtarGritsClick(object sender, RoutedEventArgs e)
        {

            MadOtarGritsOrder item = new MadOtarGritsOrder(parent, new MadOtarGrits());
            parent.menuBorder.Child = item;
            Order o = (Order)parent.DataContext;

            o.Add((IOrderItem)item.DataContext);
        }

        /// <summary>
        /// Sends the user to the Order Specifics for this menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VokunSaladClick(object sender, RoutedEventArgs e)
        {

            VokunSaladOrder item = new VokunSaladOrder(parent, new VokunSalad());
            parent.menuBorder.Child = item;
            Order o = (Order)parent.DataContext;

            o.Add((IOrderItem)item.DataContext);
        }
    }
}
