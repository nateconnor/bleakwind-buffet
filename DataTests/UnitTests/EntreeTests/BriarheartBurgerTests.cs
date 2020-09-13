/*
 * Author: Nathan Connor
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            BriarheartBurger BriBurg = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(BriBurg);
        }

        [Fact]
        public void ShouldBeOrderable()
        {
            BriarheartBurger BriBurg = new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(BriBurg);
        }


        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger BriBurg = new BriarheartBurger();
            Assert.True(BriBurg.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger BriBurg = new BriarheartBurger();
            Assert.True(BriBurg.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger BriBurg = new BriarheartBurger();
            Assert.True(BriBurg.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger BriBurg = new BriarheartBurger();
            Assert.True(BriBurg.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger BriBurg = new BriarheartBurger();
            Assert.True(BriBurg.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger BriBurg = new BriarheartBurger();
            BriBurg.Bun = false;
            Assert.False(BriBurg.Bun);
            BriBurg.Bun = true;
            Assert.True(BriBurg.Bun);
            
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger BriBurg = new BriarheartBurger();
            BriBurg.Ketchup = false;
            Assert.False(BriBurg.Ketchup);
            BriBurg.Ketchup = true;
            Assert.True(BriBurg.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger BriBurg = new BriarheartBurger();
            BriBurg.Mustard = false;
            Assert.False(BriBurg.Mustard);
            BriBurg.Mustard = true;
            Assert.True(BriBurg.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger BriBurg = new BriarheartBurger();
            BriBurg.Pickle = false;
            Assert.False(BriBurg.Pickle);
            BriBurg.Pickle = true;
            Assert.True(BriBurg.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger BriBurg = new BriarheartBurger();
            BriBurg.Cheese = false;
            Assert.False(BriBurg.Cheese);
            BriBurg.Cheese = true;
            Assert.True(BriBurg.Cheese);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger BriBurg = new BriarheartBurger();
            Assert.Equal(6.32, BriBurg.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger BriBurg = new BriarheartBurger();
            Assert.Equal(743, Convert.ToInt32(BriBurg.Calories));

        }

        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger BriBurg = new BriarheartBurger();
            BriBurg.Bun = includeBun;
            BriBurg.Ketchup = includeKetchup;
            BriBurg.Mustard = includeMustard;
            BriBurg.Pickle = includePickle;
            BriBurg.Cheese = includeCheese;
            if (!includeBun)
            {

                Assert.Contains("Hold Bun", BriBurg.SpecialInstructions);
            }
            if (!includeKetchup)
            {

                Assert.Contains("Hold Ketchup", BriBurg.SpecialInstructions);
            }
            if (!includeMustard)
            {

                Assert.Contains("Hold Mustard", BriBurg.SpecialInstructions);
            }
            if (!includePickle)
            {

                Assert.Contains("Hold Pickle", BriBurg.SpecialInstructions);
            }
            if (!includeCheese)
            {

                Assert.Contains("Hold Cheese", BriBurg.SpecialInstructions);
            }
             else if (includeBun && includeCheese && includeKetchup && includeMustard && includePickle)
            {
                Assert.Empty(BriBurg.SpecialInstructions);

            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger BriBurg = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", BriBurg.ToString());
        }
    }
}