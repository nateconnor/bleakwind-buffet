﻿/*
 * Author: Nathan Connor
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System;
using System.ComponentModel;



namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            PhillyPoacher entree = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(entree);
        }

        [Fact]
        public void ShouldBeOrderable()
        {
            PhillyPoacher entree = new PhillyPoacher();
            Assert.IsAssignableFrom<IOrderItem>(entree);
        }

        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Sirloin);
        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Onion);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Roll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Sirloin = false;
            Assert.False(pp.Sirloin);
            pp.Sirloin = true;
            Assert.True(pp.Sirloin);
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Onion = false;
            Assert.False(pp.Onion);
            pp.Onion = true;
            Assert.True(pp.Onion);
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Roll = false;
            Assert.False(pp.Roll);
            pp.Roll = true;
            Assert.True(pp.Roll);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal(7.23, pp.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal(784, Convert.ToInt32(pp.Calories));
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {

            PhillyPoacher pp = new PhillyPoacher();
            pp.Sirloin = includeSirloin;
            pp.Onion = includeOnion;
            pp.Roll = includeRoll;

            if (!includeSirloin)
            {

                Assert.Contains("Hold sirloin", pp.SpecialInstructions);
            }
            if (!includeOnion)
            {

                Assert.Contains("Hold onions", pp.SpecialInstructions);
            }
            if (!includeRoll)
            {

                Assert.Contains("Hold roll", pp.SpecialInstructions);
            }
            
            else if (includeSirloin && includeOnion && includeRoll)
            {
                Assert.Empty(pp.SpecialInstructions);

            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal("Philly Poacher", pp.ToString());
        }

        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            PhillyPoacher entree = new PhillyPoacher();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(entree);
        }

        [Fact]
        public void ChangingSirloinNotifiesSirloinProperty()
        {
            var entree = new PhillyPoacher();
            Assert.PropertyChanged(entree, "Sirloin", () =>
            {
                entree.Sirloin = true;
            });

            Assert.PropertyChanged(entree, "Sirloin", () =>
            {
                entree.Sirloin = false;
            });
        }

        [Fact]
        public void ChangingOnionNotifiesOnionProperty()
        {
            var entree = new PhillyPoacher();
            Assert.PropertyChanged(entree, "Onion", () =>
            {
                entree.Onion = true;
            });

            Assert.PropertyChanged(entree, "Onion", () =>
            {
                entree.Onion = false;
            });
        }

        [Fact]
        public void ChangingRollNotifiesRollProperty()
        {
            var entree = new PhillyPoacher();
            Assert.PropertyChanged(entree, "Roll", () =>
            {
                entree.Roll = true;
            });

            Assert.PropertyChanged(entree, "Roll", () =>
            {
                entree.Roll = false;
            });
        }
    }
}