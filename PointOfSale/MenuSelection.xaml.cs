/*
* Author: Nathan Connor
* Class name: MenuSelection.xaml.cs
* Purpose: Controls the buttons for every menu item in GUI
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class MenuSelection : UserControl
    {
         Order parent;
        public MenuSelection(Order p)
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
            
            parent.menuBorder.Child = new BriarheartBurgerOrder(parent);
            
        }

        /// <summary>
        /// Sends the user to the Order Specifics for this menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoubleDraugrClick(object sender, RoutedEventArgs e)
        {

            parent.menuBorder.Child = new DoubleDraugrOrder(parent);

        }

        /// <summary>
        /// Sends the user to the Order Specifics for this menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GardenOrcOmeletteClick(object sender, RoutedEventArgs e)
        {

            parent.menuBorder.Child = new GardenOrcOmeletteOrder(parent);

        }

        /// <summary>
        /// Sends the user to the Order Specifics for this menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhillyPoacherClick(object sender, RoutedEventArgs e)
        {

            parent.menuBorder.Child = new PhillyPoacherOrder(parent);

        }

        /// <summary>
        /// Sends the user to the Order Specifics for this menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SmokehouseSkeletonClick(object sender, RoutedEventArgs e)
        {

            parent.menuBorder.Child = new SmokehouseSkeletonOrder(parent);

        }

        /// <summary>
        /// Sends the user to the Order Specifics for this menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThalmorTripleClick(object sender, RoutedEventArgs e)
        {

            parent.menuBorder.Child = new ThalmorTripleOrder(parent);

        }

        /// <summary>
        /// Sends the user to the Order Specifics for this menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThugsTBoneClick(object sender, RoutedEventArgs e)
        {

            //parent.menuBorder.Child = new BriarheartBurgerOrder(parent);

        }

        /// <summary>
        /// Sends the user to the Order Specifics for this menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AretinoAppleJuiceClick(object sender, RoutedEventArgs e)
        {

            parent.menuBorder.Child = new AretinoAppleJuiceOrder(parent);

        }

        /// <summary>
        /// Sends the user to the Order Specifics for this menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CandlehearthCoffeeClick(object sender, RoutedEventArgs e)
        {

            parent.menuBorder.Child = new CandlehearthCoffeeOrder(parent);

        }

        /// <summary>
        /// Sends the user to the Order Specifics for this menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MarkarthMilkClick(object sender, RoutedEventArgs e)
        {

            parent.menuBorder.Child = new MarkarthMilkOrder(parent);

        }

        /// <summary>
        /// Sends the user to the Order Specifics for this menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WarriorWaterClick(object sender, RoutedEventArgs e)
        {

            parent.menuBorder.Child = new WarriorWaterOrder(parent);

        }

        /// <summary>
        /// Sends the user to the Order Specifics for this menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SailorSodaClick(object sender, RoutedEventArgs e)
        {

            parent.menuBorder.Child = new SailorSodaOrder(parent);

        }

        /// <summary>
        /// Sends the user to the Order Specifics for this menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DragonbornWaffleFriesClick(object sender, RoutedEventArgs e)
        {

            parent.menuBorder.Child = new DragonbornWaffleFriesOrder(parent);

        }

        /// <summary>
        /// Sends the user to the Order Specifics for this menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FriedMiraakClick(object sender, RoutedEventArgs e)
        {

            parent.menuBorder.Child = new FriedMiraakOrder(parent);

        }

        /// <summary>
        /// Sends the user to the Order Specifics for this menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MadOtarGritsClick(object sender, RoutedEventArgs e)
        {

            parent.menuBorder.Child = new MadOtarGritsOrder(parent);

        }

        /// <summary>
        /// Sends the user to the Order Specifics for this menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VokunSaladClick(object sender, RoutedEventArgs e)
        {

            parent.menuBorder.Child = new VokunSaladOrder(parent);

        }
    }
}
