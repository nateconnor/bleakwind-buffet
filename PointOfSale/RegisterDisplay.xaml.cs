/*
* Author: Nathan Connor
* Class name: RegisterDisplay.xaml.cs
* Purpose: Allows the user to enter the amount of money they owe and receive change
*/
using RoundRegister;
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
using BleakwindBuffet.Data;
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for RegisterDisplay.xaml
    /// </summary>
    public partial class RegisterDisplay : UserControl
    {
        OrderMenu parent;
        private double total;
        RegisterViewModel rvm;
        public RegisterDisplay(OrderMenu p, double t)

        {
            InitializeComponent();
            parent = p;
            total = t;
            uxTotalSale.Text = "$" + total.ToString("0.##");
            rvm = new RegisterViewModel(total);

            //May need to add a handle property changed thing here

            DataContext = rvm;
        }

        /// <summary>
        /// returns the user to the menu selection screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Return_Click(object sender, RoutedEventArgs e)
        {
            parent.menuBorder.Child = new MenuSelection(parent);
            parent.uxDeleteButton.IsEnabled = true;

        }

       /// <summary>
       /// Finalizes the order and makes sure the proper amount has been entered
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void Finalize_Click(object sender, RoutedEventArgs e)
        {
            if (rvm.AmountDue > 0)
            {
                MessageBox.Show("Error: Insufficient Funds");
            }
            else
            {
                rvm.FinalizeSale();

                parent.PrintReceipt(0, rvm.ChangeOwed);
                parent.DataContext = new Order();

                parent.menuBorder.Child = new MenuSelection(parent);
                parent.uxDeleteButton.IsEnabled = true;
            }
            
        }
    }
}
