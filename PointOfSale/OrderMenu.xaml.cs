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
using RoundRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for Order.xaml
    /// </summary>
    public partial class OrderMenu : UserControl
    {
        protected Order _order;
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
            
            menuBorder.Child = new PaymentOptions(this, _order.Total);
            uxDeleteButton.IsEnabled = false;
        }

        /// <summary>
        /// Cancels the order and creates a new one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            _order = new Order();
            DataContext = _order;
            menuBorder.Child = new MenuSelection(this);
            uxDeleteButton.IsEnabled = true;


        }

        public void PrintReceipt(int paymentMethod, double change)
        {
            RecieptPrinter.PrintLine("Order " + _order.Number);
            DateTime time = DateTime.Now;
            RecieptPrinter.PrintLine(time.ToString());


            //A complete list of all items in the order, including their price and special instructions
            RecieptPrinter.PrintLine("---ORDER---");


            foreach (IOrderItem item in _order)
            {
                if (item.ToString().Length <= 40)
                {
                    RecieptPrinter.PrintLine(item.ToString());
                }
                else
                {
                    string first = item.ToString().Substring(0, 40);
                    string second = item.ToString().Substring(40);
                }
                foreach(string text in item.SpecialInstructions)
                {
                    RecieptPrinter.PrintLine(" -"+ text);
                }
            }

            RecieptPrinter.PrintLine("---------------------------------------");


            RecieptPrinter.PrintLine("Subtotal: $" + _order.Subtotal.ToString("0.##"));
            RecieptPrinter.PrintLine("Tax: $" + _order.Tax.ToString("0.##"));
            RecieptPrinter.PrintLine("Total: $" + _order.Total.ToString("0.##"));
            if (paymentMethod == 0)
            {
                RecieptPrinter.PrintLine("---Cash Payment---");
                RecieptPrinter.PrintLine("Change Owed: $" + change.ToString("0.##"));


            }
            else if (paymentMethod == 1)
            {
                RecieptPrinter.PrintLine("---Card Payment---");

            }

            RecieptPrinter.CutTape();
        }
    }
}
