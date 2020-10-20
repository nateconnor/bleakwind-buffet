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
        public static DependencyProperty CustomerQuantityProperty = DependencyProperty.Register("CustomerQuantity", typeof(int), typeof(CurrencyControl));

        public static DependencyProperty ChangeQuantityProperty = DependencyProperty.Register("ChangeQuantity", typeof(int), typeof(CurrencyControl));

        public static DependencyProperty LabelTextProperty = DependencyProperty.Register("LabelText", typeof(string), typeof(CurrencyControl));



        public int CustomerQuantity
        {
            get =>

                (int)GetValue(CustomerQuantityProperty);

            set
            {
                SetValue(CustomerQuantityProperty, value);
            }
        }



        public int ChangeQuantity
        {
            get =>

                (int)GetValue(ChangeQuantityProperty);

            set
            {
                SetValue(ChangeQuantityProperty, value);
            }
        }

        public string LabelText
        {
            get =>

                (string)GetValue(LabelTextProperty);

            set
            {
                SetValue(LabelTextProperty, value);
            }
        }
        public CurrencyControl()
        {
            InitializeComponent();
           
        }

        private void Increase_Click(object sender, RoutedEventArgs e)
        {
            CustomerQuantity++;
        }

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

        /// <summary>
        /// Callback for the ValueProperty, which clamps the Value to the range 
        /// defined by MinValue and MaxValue
        /// </summary>
        /// <param name="sender">The NumberBox whose value is changing</param>
        /// <param name="e">The event args</param>
    //    static void HandleValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
    //    {
    //        if (e.Property.Name == "Value" && sender is NumberBox box)
    //        {
    //            if (box.Value < box.MinValue)
    //            {
    //                box.Value = box.MinValue;
    //                box.RaiseEvent(new RoutedEventArgs(ValueClampedEvent));
    //            }
    //            if (box.Value > box.MaxValue)
    //            {
    //                box.Value = box.MaxValue;
    //                box.RaiseEvent(new RoutedEventArgs(ValueClampedEvent));
    //            }
    //        }
    //    }

    //    public event PropertyChangedEventHandler PropertyChanged;
    }
}
