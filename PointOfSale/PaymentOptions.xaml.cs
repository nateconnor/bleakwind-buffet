/*
* Author: Nathan Connor
* Class name: PaymentOptions.xaml.cs
* Purpose: Chooses the payment type for the customer
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
using System.Xml.Schema;
using BleakwindBuffet.Data;
using RoundRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PaymentOptions.xaml
    /// </summary>
    public partial class PaymentOptions : UserControl
    {
        OrderMenu parent;
        private double total;

        public PaymentOptions(OrderMenu p, double t)
        {
            InitializeComponent();
            parent = p;
            total = t;

        }

       

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            parent.menuBorder.Child = new MenuSelection(parent);
            parent.uxDeleteButton.IsEnabled = true;

        }

        private void Cash_Click(object sender, RoutedEventArgs e)
        {
            //display cash drawer
            parent.menuBorder.Child = new RegisterDisplay(parent, total);

        }

        private void CreditDebit_Click(object sender, RoutedEventArgs e)
        {
           CardTransactionResult result = CardReader.RunCard(total);
            switch (result)
            {
                case CardTransactionResult.Approved:
                    //print RECEIPT
                    parent.PrintReceipt(1, 0);
                    //reset order
                    parent.DataContext = new Order();
                    parent.menuBorder.Child = new MenuSelection(parent);
                    parent.uxDeleteButton.IsEnabled = true;

                    break;
                case CardTransactionResult.Declined:
                    MessageBox.Show("Card Declined");
                    break;
                case CardTransactionResult.InsufficientFunds:
                    MessageBox.Show("Insufficient Funds");

                    break;
                case CardTransactionResult.IncorrectPin:
                    MessageBox.Show("Incorrect Pin");

                    break;
                case CardTransactionResult.ReadError:
                    MessageBox.Show("Read Error");

                    break;
            }
        }



    }
}
