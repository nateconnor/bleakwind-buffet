﻿/*
 * Author: Nathan Connor
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;



namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ShouldBeADrink()
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            Assert.IsAssignableFrom<Drink>(cof);
        }

        [Fact]
        public void ShouldBeOrderable()
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            Assert.IsAssignableFrom<IOrderItem>(cof);
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            Assert.False(cof.Ice);
        }

        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            Assert.False(cof.Decaf);
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            Assert.False(cof.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            Assert.Equal(Size.Small, cof.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            cof.Ice = true;
            Assert.True(cof.Ice);
            cof.Ice = false;
            Assert.False(cof.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            cof.Decaf = true;
            Assert.True(cof.Decaf);
            cof.Decaf = false;
            Assert.False(cof.Decaf);
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            cof.RoomForCream = true;
            Assert.True(cof.RoomForCream);
            cof.RoomForCream = false;
            Assert.False(cof.RoomForCream);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            cof.Size = Size.Large;
            Assert.Equal(Size.Large, cof.Size);
            cof.Size = Size.Medium;
            Assert.Equal(Size.Medium, cof.Size);
            cof.Size = Size.Small;
            Assert.Equal(Size.Small, cof.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            cof.Size = size;
            Assert.Equal(price, cof.Price);
        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            cof.Size = size;
            Assert.Equal(cal, cof.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            cof.Ice = includeIce;
            cof.RoomForCream = includeCream;
            if (includeIce)
            {

                Assert.Contains("Add ice", cof.SpecialInstructions);
            }
            if (includeCream)
            {
                Assert.Contains("Add cream", cof.SpecialInstructions);
            }
            else if (!includeCream && !includeIce)
            {
                Assert.Empty(cof.SpecialInstructions);
            }
        }

        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            cof.Size = size;
            cof.Decaf = decaf;

            Assert.Equal(name, cof.ToString());
        }


        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            CandlehearthCoffee aj = new CandlehearthCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(aj);
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var aj = new CandlehearthCoffee();
            Assert.PropertyChanged(aj, "Ice", () =>
            {
                aj.Ice = true;
            });

            Assert.PropertyChanged(aj, "Ice", () =>
            {
                aj.Ice = false;
            });
        }

        [Fact]
        public void ChangingDecafNotifiesProperty()
        {
            var drink = new CandlehearthCoffee();
            Assert.PropertyChanged(drink, "Decaf", () =>
            {
                drink.Decaf = true;
            });

            Assert.PropertyChanged(drink, "Decaf", () =>
            {
                drink.Decaf = false;
            });
        }

        [Fact]
        public void ChangingCreamNotifiesProperty()
        {
            var drink = new CandlehearthCoffee();
            Assert.PropertyChanged(drink, "RoomForCream", () =>
            {
                drink.RoomForCream = true;
            });

            Assert.PropertyChanged(drink, "RoomForCream", () =>
            {
                drink.RoomForCream = false;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var drink = new CandlehearthCoffee();

            Assert.PropertyChanged(drink, "Size", () =>
            {
                drink.Size = Size.Small;
            });

            Assert.PropertyChanged(drink, "Size", () =>
            {
                drink.Size = Size.Medium;
            });

            Assert.PropertyChanged(drink, "Size", () =>
            {
                drink.Size = Size.Large;
            });
        }
    }
}
