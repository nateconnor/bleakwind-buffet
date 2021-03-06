﻿/*
 * Author: Nathan Connor
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System;
using System.ComponentModel;


namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            ThalmorTriple entree = new ThalmorTriple();
            Assert.IsAssignableFrom<Entree>(entree);
        }

        [Fact]
        public void ShouldBeOrderable()
        {
            ThalmorTriple entree = new ThalmorTriple();
            Assert.IsAssignableFrom<IOrderItem>(entree);
        }

        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Mayo);
        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Bacon);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bun = false;
            Assert.False(tt.Bun);
            tt.Bun = true;
            Assert.True(tt.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Ketchup = false;
            Assert.False(tt.Ketchup);
            tt.Ketchup = true;
            Assert.True(tt.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Mustard = false;
            Assert.False(tt.Mustard);
            tt.Mustard = true;
            Assert.True(tt.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Pickle = false;
            Assert.False(tt.Pickle);
            tt.Pickle = true;
            Assert.True(tt.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Cheese = false;
            Assert.False(tt.Cheese);
            tt.Cheese = true;
            Assert.True(tt.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Tomato = false;
            Assert.False(tt.Tomato);
            tt.Tomato = true;
            Assert.True(tt.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Lettuce = false;
            Assert.False(tt.Lettuce);
            tt.Lettuce = true;
            Assert.True(tt.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Mayo = false;
            Assert.False(tt.Mayo);
            tt.Mayo = true;
            Assert.True(tt.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bacon = false;
            Assert.False(tt.Bacon);
            tt.Bacon = true;
            Assert.True(tt.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Egg = false;
            Assert.False(tt.Egg);
            tt.Egg = true;
            Assert.True(tt.Egg);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal(8.32, tt.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal(943, Convert.ToInt32(tt.Calories));

        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bun = includeBun;
            tt.Ketchup = includeKetchup;
            tt.Mustard = includeMustard;
            tt.Pickle = includePickle;
            tt.Cheese = includeCheese;
            tt.Tomato = includeTomato;
            tt.Lettuce = includeLettuce;
            tt.Mayo = includeMayo;
            tt.Bacon = includeBacon;
            tt.Egg = includeEgg;
            if (!includeBun)
            {

                Assert.Contains("Hold Bun", tt.SpecialInstructions);
            }
            if (!includeKetchup)
            {

                Assert.Contains("Hold Ketchup", tt.SpecialInstructions);
            }
            if (!includeMustard)
            {

                Assert.Contains("Hold Mustard", tt.SpecialInstructions);
            }
            if (!includePickle)
            {

                Assert.Contains("Hold Pickle", tt.SpecialInstructions);
            }
            if (!includeCheese)
            {

                Assert.Contains("Hold Cheese", tt.SpecialInstructions);
            }
            if (!includeTomato)
            {

                Assert.Contains("Hold Tomato", tt.SpecialInstructions);
            }
            if (!includeLettuce)
            {

                Assert.Contains("Hold Lettuce", tt.SpecialInstructions);
            }
            if (!includeMayo)
            {

                Assert.Contains("Hold Mayo", tt.SpecialInstructions);
            }
            if (!includeBacon)
            {

                Assert.Contains("Hold Bacon", tt.SpecialInstructions);
            }
            if (!includeEgg)
            {

                Assert.Contains("Hold Egg", tt.SpecialInstructions);
            }
            else if (includeBun && includeCheese && includeKetchup && includeMustard && includePickle && includeTomato && includeLettuce && includeMayo && includeEgg && includeBacon)
            {
                Assert.Empty(tt.SpecialInstructions);

            }


        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", tt.ToString());
        }

        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            ThalmorTriple entree = new ThalmorTriple();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(entree);
        }

        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            var entree = new ThalmorTriple();
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
            var entree = new ThalmorTriple();
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
            var entree = new ThalmorTriple();
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
            var entree = new ThalmorTriple();
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
            var entree = new ThalmorTriple();
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
            var entree = new ThalmorTriple();
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
            var entree = new ThalmorTriple();
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
            var entree = new ThalmorTriple();
            Assert.PropertyChanged(entree, "Mayo", () =>
            {
                entree.Mayo = true;
            });

            Assert.PropertyChanged(entree, "Mayo", () =>
            {
                entree.Mayo = false;
            });
        }

        [Fact]
        public void ChangingBaconNotifiesBaconProperty()
        {
            var entree = new ThalmorTriple();
            Assert.PropertyChanged(entree, "Bacon", () =>
            {
                entree.Bacon = true;
            });

            Assert.PropertyChanged(entree, "Bacon", () =>
            {
                entree.Bacon = false;
            });
        }

        [Fact]
        public void ChangingEggNotifiesEggProperty()
        {
            var entree = new ThalmorTriple();
            Assert.PropertyChanged(entree, "Egg", () =>
            {
                entree.Egg = true;
            });

            Assert.PropertyChanged(entree, "Egg", () =>
            {
                entree.Egg = false;
            });
        }
    }
}