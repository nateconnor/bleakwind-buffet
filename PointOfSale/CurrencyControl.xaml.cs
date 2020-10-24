/*
* Author: Nathan Connor
* Class name: CurrencyControl.xaml.cs
* Purpose: A custom control that controls the user quantity and change quantity of the register
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for CurrencyControl.xaml
    /// </summary>
    public partial class CurrencyControl : UserControl
    {
        
        public static DependencyProperty CustomerQuantityProperty = DependencyProperty.Register("CustomerQuantity", typeof(int), typeof(CurrencyControl),
            new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public static DependencyProperty ChangeQuantityProperty = DependencyProperty.Register("ChangeQuantity", typeof(int), typeof(CurrencyControl),
             new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public static DependencyProperty LabelTextProperty = DependencyProperty.Register("LabelText", typeof(string), typeof(CurrencyControl));


        /// <summary>
        /// The amount of currency that the customer has deposited
        /// </summary>
        public int CustomerQuantity
        {
            get =>

                (int)GetValue(CustomerQuantityProperty);

            set
            {
                SetValue(CustomerQuantityProperty, value);
            }
        }


        /// <summary>
        /// The amount of change that the customer is owed
        /// </summary>
        public int ChangeQuantity
        {
            get =>

                (int)GetValue(ChangeQuantityProperty);

            set
            {
                SetValue(ChangeQuantityProperty, value);
            }
        }

        /// <summary>
        /// The display of what kind of currency is being transferred
        /// </summary>
        public string LabelText
        {
            get =>

                (string)GetValue(LabelTextProperty);

            set
            {
                SetValue(LabelTextProperty, value);
            }
        }

        /// <summary>
        /// constructor for a currency control wpf
        /// </summary>
        public CurrencyControl()
        {
            InitializeComponent();
            uxIncreaseButton.Click += HandleButtonClick;
            uxDecreaseButton.Click += HandleButtonClick;


        }

        /// <summary>
        /// increases the customer quantity
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Increase_Click(object sender, RoutedEventArgs e)
        {
            CustomerQuantity++;
        }


        /// <summary>
        /// decreases the customer quantity
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Decrease_Click(object sender, RoutedEventArgs e)
        {
            if (CustomerQuantity != 0)
            {
                CustomerQuantity--;

            }

        }

        /// <summary>
        /// Handles the click of the increment or decrement button
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The event arguments</param>
        void HandleButtonClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {

                switch (button.Name)
                {

                    case "uxIncreaseButton":
                        CustomerQuantity += 1;
                        break;
                    case "uxDecreaseButton":
                        if (CustomerQuantity != 0)
                        
                            CustomerQuantity -= 1;
                        break;

                }

            }
            e.Handled = true;
        }


        /// <summary>
        /// Identifies the NumberBox.ValueClamped event
        /// </summary>
        public static readonly RoutedEvent ValueClampedEvent = EventManager.RegisterRoutedEvent("ValueClamped", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(CurrencyControl));
        
        /// <summary>
        /// Event that is triggered when the value of this NumberBox changes
        /// </summary>
        public event RoutedEventHandler ValueClamped
        {
            add { AddHandler(ValueClampedEvent, value); }
            remove { RemoveHandler(ValueClampedEvent, value); }
        }

        

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
