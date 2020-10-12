
 using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests
{
   public class OrderTests
    {
        [Fact]
        public void AddingItemAddsToOrder()
        {
            Order o = new Order();
            BriarheartBurger burg = new BriarheartBurger();
            o.Add(burg);
            Assert.Contains(burg, o);

            
        }

        [Fact]
        public void RemovingItemRemovesFromOrder()
        {
            Order o = new Order();
            BriarheartBurger burg = new BriarheartBurger();
            o.Add(burg);
            Assert.Contains(burg, o);
            o.Remove(burg);
            Assert.Empty(o);


        }

        [Fact]
        public void OrderIsEmptyOnInitialization()
        {
            Order o = new Order();
           
            Assert.Empty(o);


        }


        [Fact]
        public void OrderCountIsCorrect()
        {
            Order o = new Order();

            
            BriarheartBurger burg = new BriarheartBurger();
            o.Add(burg);
            Assert.Single(o);

            ThalmorTriple burg2 = new ThalmorTriple();
            o.Add(burg2);
            Assert.Equal(2, o.Count);


        }

        [Fact]
        public void OrderCostIsCorrect()
        {
            Order o = new Order();


            BriarheartBurger burg = new BriarheartBurger();
            o.Add(burg);
            Assert.Equal(burg.Price, o.Subtotal);
            Assert.Equal(burg.Price*o.SalesTaxRate, o.Tax);
            Assert.Equal(burg.Price * o.SalesTaxRate + burg.Price, o.Total);





        }


        [Fact]
        public void OrderCaloriesAreCorrect()
        {
            Order o = new Order();


            BriarheartBurger burg = new BriarheartBurger();
            o.Add(burg);
            Assert.Equal(burg.Calories, o.Calories);
            ThalmorTriple burg2 = new ThalmorTriple();
            o.Add(burg2);
            Assert.Equal(burg.Calories + burg2.Calories, o.Calories);





        }

        [Fact]
        public void AddingItemNotifiesProperties()
        {
            Order o = new Order();
            Assert.PropertyChanged(o, "Subtotal", () =>
            {
                o.Add(new BriarheartBurger());
            });

            Assert.PropertyChanged(o, "Tax", () =>
            {
                o.Add(new BriarheartBurger());
            });
            Assert.PropertyChanged(o, "Total", () =>
            {
                o.Add(new BriarheartBurger());
            });
            Assert.PropertyChanged(o, "Calories", () =>
            {
                o.Add(new BriarheartBurger());
            });
            
        }

        //[Fact]
        //public void AddingItemNotifiesCollectionChange()
        //{
        //    Order o = new Order();
        //    Assert.Raises<CollectionChangeEventArgs>(CollecionCahngedListener => o+=)

        //}

        [Fact]
        public void RemovingItemNotifiesProperties()
        {
            Order o = new Order();
            Assert.PropertyChanged(o, "Subtotal", () =>
            {
                o.Remove(new BriarheartBurger());
            });

            Assert.PropertyChanged(o, "Tax", () =>
            {
                o.Remove(new BriarheartBurger());
            });
            Assert.PropertyChanged(o, "Total", () =>
            {
                o.Remove(new BriarheartBurger());
            });
            Assert.PropertyChanged(o, "Calories", () =>
            {
                o.Remove(new BriarheartBurger());
            });

        }

        [Fact]
        public void EditingItemNotifiesProperties()
        {
            Order o = new Order();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            o.Add(aj);
            Assert.PropertyChanged(o, "Subtotal", () =>
            {
                aj.Size = Size.Large;
            });

            Assert.PropertyChanged(o, "Tax", () =>
            {
                aj.Size = Size.Medium;
            });
            Assert.PropertyChanged(o, "Total", () =>
            {
                aj.Size = Size.Large;
            });
            Assert.PropertyChanged(o, "Calories", () =>
            {
                aj.Size = Size.Medium;
            });

        }



    }
}
