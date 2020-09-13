using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTests
    {
        [Fact]
        public void AllEntreesInMenu()
        {
            IEnumerable<IOrderItem> temp = Menu.Entrees();
            List<IOrderItem> entrees = (List<IOrderItem>)temp;

            Assert.Collection(entrees,
                entree => Assert.Contains("Briarheart Burger", entree.ToString()),
            entree => Assert.Contains("Double Draugr", entree.ToString()),
            entree => Assert.Contains("Garden Orc Omelette", entree.ToString()),
            entree => Assert.Contains("Philly Poacher", entree.ToString()),
            entree => Assert.Contains("Smokehouse Skeleton", entree.ToString()),
            entree => Assert.Contains("Thalmor Triple", entree.ToString()),
            entree => Assert.Contains("Thugs T-Bone", entree.ToString()));

            Assert.Equal(7, entrees.Count);

        }

        [Fact]
        public void AllSidesInMenu()
        {
            IEnumerable<IOrderItem> temp = Menu.Sides();
            List<IOrderItem> sides = (List<IOrderItem>)temp;

            Assert.Collection(sides,
                side => Assert.Contains("Small Dragonborn Waffle Fries", side.ToString()),
                side => Assert.Contains("Small Fried Miraak", side.ToString()),
                side => Assert.Contains("Small Mad Otar Grits", side.ToString()),
                side => Assert.Contains("Small Vokun Salad", side.ToString()),


                 side => Assert.Contains("Medium Dragonborn Waffle Fries", side.ToString()),
                 side => Assert.Contains("Medium Fried Miraak", side.ToString()),
                 side => Assert.Contains("Medium Mad Otar Grits", side.ToString()),
                 side => Assert.Contains("Medium Vokun Salad", side.ToString()),


                  side => Assert.Contains("Large Dragonborn Waffle Fries", side.ToString()),




            side => Assert.Contains("Large Fried Miraak", side.ToString()),



            side => Assert.Contains("Large Mad Otar Grits", side.ToString()),



            side => Assert.Contains("Large Vokun Salad", side.ToString()));




            Assert.Equal(12, sides.Count);

        }



        [Fact]
        public void AllDrinksInMenu()
        {
            IEnumerable<IOrderItem> temp = Menu.Drinks();
            List<IOrderItem> drinks = (List<IOrderItem>)temp;

            Assert.Collection(drinks,
                drink => Assert.Contains("Small Aretino Apple Juice", drink.ToString()),
                drink => Assert.Contains("Small Candlehearth Coffee", drink.ToString()),
                drink => Assert.Contains("Small Decaf Candlehearth Coffee", drink.ToString()),
                drink => Assert.Contains("Small Markarth Milk", drink.ToString()),
                 drink => Assert.Contains("Small Warrior Water", drink.ToString()),


                 drink => Assert.Contains("Medium Aretino Apple Juice", drink.ToString()),
                 drink => Assert.Contains("Medium Candlehearth Coffee", drink.ToString()),
                 drink => Assert.Contains("Medium Decaf Candlehearth Coffee", drink.ToString()),
                 drink => Assert.Contains("Medium Markarth Milk", drink.ToString()),
                 drink => Assert.Contains("Medium Warrior Water", drink.ToString()),

                  drink => Assert.Contains("Large Aretino Apple Juice", drink.ToString()),
            drink => Assert.Contains("Large Candlehearth Coffee", drink.ToString()),

            drink => Assert.Contains("Large Decaf Candlehearth Coffee", drink.ToString()),


            drink => Assert.Contains("Large Markarth Milk", drink.ToString()),


            drink => Assert.Contains("Large Warrior Water", drink.ToString()),

            drink => Assert.Contains("Small Cherry Sailor Soda", drink.ToString()),
            drink => Assert.Contains("Small Blackberry Sailor Soda", drink.ToString()),
             drink => Assert.Contains("Small Grapefruit Sailor Soda", drink.ToString()),
                         drink => Assert.Contains("Small Lemon Sailor Soda", drink.ToString()),
                                     drink => Assert.Contains("Small Peach Sailor Soda", drink.ToString()),
            drink => Assert.Contains("Small Watermelon Sailor Soda", drink.ToString()),



                        drink => Assert.Contains("Medium Cherry Sailor Soda", drink.ToString()),

            drink => Assert.Contains("Medium Blackberry Sailor Soda", drink.ToString()),
                        drink => Assert.Contains("Medium Grapefruit Sailor Soda", drink.ToString()),
                                    drink => Assert.Contains("Medium Lemon Sailor Soda", drink.ToString()),
                                                drink => Assert.Contains("Medium Peach Sailor Soda", drink.ToString()),
                                                            drink => Assert.Contains("Medium Watermelon Sailor Soda", drink.ToString()),

            drink => Assert.Contains("Large Cherry Sailor Soda", drink.ToString()),


            drink => Assert.Contains("Large Blackberry Sailor Soda", drink.ToString()),




            drink => Assert.Contains("Large Grapefruit Sailor Soda", drink.ToString()),

            drink => Assert.Contains("Large Lemon Sailor Soda", drink.ToString()),

            drink => Assert.Contains("Large Peach Sailor Soda", drink.ToString()),

            drink => Assert.Contains("Large Watermelon Sailor Soda", drink.ToString()));









            Assert.Equal(33, drinks.Count);

        }


        [Fact]
        public void AllItemsInMenu()
        {
            IEnumerable<IOrderItem> temp = Menu.FullMenu();
            List<IOrderItem> menu = (List<IOrderItem>)temp;

            Assert.Collection(menu,
                item => Assert.Contains("Briarheart Burger", item.ToString()),
            item => Assert.Contains("Double Draugr", item.ToString()),
            item => Assert.Contains("Garden Orc Omelette", item.ToString()),
            item => Assert.Contains("Philly Poacher", item.ToString()),
            item => Assert.Contains("Smokehouse Skeleton", item.ToString()),
            item => Assert.Contains("Thalmor Triple", item.ToString()),
            item => Assert.Contains("Thugs T-Bone", item.ToString()),
            item => Assert.Contains("Small Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Contains("Small Fried Miraak", item.ToString()),
                item => Assert.Contains("Small Mad Otar Grits", item.ToString()),
                item => Assert.Contains("Small Vokun Salad", item.ToString()),


                 item => Assert.Contains("Medium Dragonborn Waffle Fries", item.ToString()),
                 item => Assert.Contains("Medium Fried Miraak", item.ToString()),
                 item => Assert.Contains("Medium Mad Otar Grits", item.ToString()),
                 item => Assert.Contains("Medium Vokun Salad", item.ToString()),


                  item => Assert.Contains("Large Dragonborn Waffle Fries", item.ToString()),




            item => Assert.Contains("Large Fried Miraak", item.ToString()),



            item => Assert.Contains("Large Mad Otar Grits", item.ToString()),



            item => Assert.Contains("Large Vokun Salad", item.ToString()),

            item => Assert.Contains("Small Aretino Apple Juice", item.ToString()),
                item => Assert.Contains("Small Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Small Decaf Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Small Markarth Milk", item.ToString()),
                 item => Assert.Contains("Small Warrior Water", item.ToString()),


                 item => Assert.Contains("Medium Aretino Apple Juice", item.ToString()),
                 item => Assert.Contains("Medium Candlehearth Coffee", item.ToString()),
                 item => Assert.Contains("Medium Decaf Candlehearth Coffee", item.ToString()),
                 item => Assert.Contains("Medium Markarth Milk", item.ToString()),
                 item => Assert.Contains("Medium Warrior Water", item.ToString()),

                  item => Assert.Contains("Large Aretino Apple Juice", item.ToString()),
            item => Assert.Contains("Large Candlehearth Coffee", item.ToString()),

            item => Assert.Contains("Large Decaf Candlehearth Coffee", item.ToString()),


            item => Assert.Contains("Large Markarth Milk", item.ToString()),


            item => Assert.Contains("Large Warrior Water", item.ToString()),

            item => Assert.Contains("Small Cherry Sailor Soda", item.ToString()),
            item => Assert.Contains("Small Blackberry Sailor Soda", item.ToString()),
             item => Assert.Contains("Small Grapefruit Sailor Soda", item.ToString()),
                         item => Assert.Contains("Small Lemon Sailor Soda", item.ToString()),
                                     item => Assert.Contains("Small Peach Sailor Soda", item.ToString()),
            item => Assert.Contains("Small Watermelon Sailor Soda", item.ToString()),



                        item => Assert.Contains("Medium Cherry Sailor Soda", item.ToString()),

            item => Assert.Contains("Medium Blackberry Sailor Soda", item.ToString()),
                        item => Assert.Contains("Medium Grapefruit Sailor Soda", item.ToString()),
                                    item => Assert.Contains("Medium Lemon Sailor Soda", item.ToString()),
                                                item => Assert.Contains("Medium Peach Sailor Soda", item.ToString()),
                                                            item => Assert.Contains("Medium Watermelon Sailor Soda", item.ToString()),

            item => Assert.Contains("Large Cherry Sailor Soda", item.ToString()),


            item => Assert.Contains("Large Blackberry Sailor Soda", item.ToString()),




            item => Assert.Contains("Large Grapefruit Sailor Soda", item.ToString()),

            item => Assert.Contains("Large Lemon Sailor Soda", item.ToString()),

            item => Assert.Contains("Large Peach Sailor Soda", item.ToString()),

            item => Assert.Contains("Large Watermelon Sailor Soda", item.ToString()));

            Assert.Equal(52, menu.Count);


        }


    }
}
