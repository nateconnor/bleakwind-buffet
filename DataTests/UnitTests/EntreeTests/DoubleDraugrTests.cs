﻿/*
 * Author: Nathan Connor
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System;
using System.ComponentModel;


namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            DoubleDraugr entree = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(entree);
        }

        [Fact]
        public void ShouldBeOrderable()
        {
            DoubleDraugr entree = new DoubleDraugr();
            Assert.IsAssignableFrom<IOrderItem>(entree);
        }

        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Bun = false;
            Assert.False(dd.Bun);
            dd.Bun = true;
            Assert.True(dd.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Ketchup = false;
            Assert.False(dd.Ketchup);
            dd.Ketchup = true;
            Assert.True(dd.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Mustard = false;
            Assert.False(dd.Mustard);
            dd.Mustard = true;
            Assert.True(dd.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Pickle = false;
            Assert.False(dd.Pickle);
            dd.Pickle = true;
            Assert.True(dd.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Cheese = false;
            Assert.False(dd.Cheese);
            dd.Cheese = true;
            Assert.True(dd.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Tomato = false;
            Assert.False(dd.Tomato);
            dd.Tomato = true;
            Assert.True(dd.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Lettuce = false;
            Assert.False(dd.Lettuce);
            dd.Lettuce = true;
            Assert.True(dd.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Mayo = false;
            Assert.False(dd.Mayo);
            dd.Mayo = true;
            Assert.True(dd.Mayo);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal(7.32, dd.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal(843, Convert.ToInt32(dd.Calories));
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Bun = includeBun;
            dd.Ketchup = includeKetchup;
            dd.Mustard = includeMustard;
            dd.Pickle = includePickle;
            dd.Cheese = includeCheese;
            dd.Tomato = includeTomato;
            dd.Lettuce = includeLettuce;
            dd.Mayo = includeMayo;
            if (!includeBun)
            {

                Assert.Contains("Hold Bun", dd.SpecialInstructions);
            }
            if (!includeKetchup)
            {

                Assert.Contains("Hold Ketchup", dd.SpecialInstructions);
            }
            if (!includeMustard)
            {

                Assert.Contains("Hold Mustard", dd.SpecialInstructions);
            }
            if (!includePickle)
            {

                Assert.Contains("Hold Pickle", dd.SpecialInstructions);
            }
            if (!includeCheese)
            {

                Assert.Contains("Hold Cheese", dd.SpecialInstructions);
            }
            if (!includeTomato)
            {

                Assert.Contains("Hold Tomato", dd.SpecialInstructions);
            }
            if (!includeLettuce)
            {

                Assert.Contains("Hold Lettuce", dd.SpecialInstructions);
            }
            if (!includeMayo)
            {

                Assert.Contains("Hold Mayo", dd.SpecialInstructions);
            }
            else if (includeBun && includeCheese && includeKetchup && includeMustard && includePickle && includeTomato && includeLettuce && includeMayo)
            {
                Assert.Empty(dd.SpecialInstructions);

            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal("Double Draugr", dd.ToString());
        }


        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            DoubleDraugr entree = new DoubleDraugr();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(entree);
        }

        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            var entree = new DoubleDraugr();
            Assert.PropertyChanged(entree, "Bun", () =>
            {
                entree.Bun = true;
            });

            Assert.PropertyChanged(entree, "Bun", () =>
            {
                entree.Bun = false;
            });
        }

        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            var entree = new DoubleDraugr();
            Assert.PropertyChanged(entree, "Ketchup", () =>
            {
                entree.Ketchup = true;
            });

            Assert.PropertyChanged(entree, "Ketchup", () =>
            {
                entree.Ketchup = false;
            });
        }

        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            var entree = new DoubleDraugr();
            Assert.PropertyChanged(entree, "Mustard", () =>
            {
                entree.Mustard = true;
            });

            Assert.PropertyChanged(entree, "Mustard", () =>
            {
                entree.Mustard = false;
            });
        }


        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            var entree = new DoubleDraugr();
            Assert.PropertyChanged(entree, "Pickle", () =>
            {
                entree.Pickle = true;
            });

            Assert.PropertyChanged(entree, "Pickle", () =>
            {
                entree.Pickle = false;
            });
        }

        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            var entree = new DoubleDraugr();
            Assert.PropertyChanged(entree, "Cheese", () =>
            {
                entree.Cheese = true;
            });

            Assert.PropertyChanged(entree, "Cheese", () =>
            {
                entree.Cheese = false;
            });
        }

        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            var entree = new DoubleDraugr();
            Assert.PropertyChanged(entree, "Tomato", () =>
            {
                entree.Tomato = true;
            });

            Assert.PropertyChanged(entree, "Tomato", () =>
            {
                entree.Tomato = false;
            });
        }

        [Fact]
        public void ChangingLettuceNotifiesLettuceProperty()
        {
            var entree = new DoubleDraugr();
            Assert.PropertyChanged(entree, "Lettuce", () =>
            {
                entree.Lettuce = true;
            });

            Assert.PropertyChanged(entree, "Lettuce", () =>
            {
                entree.Lettuce = false;
            });
        }

        [Fact]
        public void ChangingMayoNotifiesMayoProperty()
        {
            var entree = new DoubleDraugr();
            Assert.PropertyChanged(entree, "Mayo", () =>
            {
                entree.Mayo = true;
            });

            Assert.PropertyChanged(entree, "Mayo", () =>
            {
                entree.Mayo = false;
            });
        }


    }
}