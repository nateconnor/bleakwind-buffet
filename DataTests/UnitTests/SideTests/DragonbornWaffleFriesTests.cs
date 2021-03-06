﻿/*
 * Author: Nathan Connor
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class DragonbornWaffleFriesTests
    {
        [Fact]
        public void ShouldBeASide()
        {
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<Side>(side);
        }

        [Fact]
        public void ShouldBeOrderable()
        {
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<IOrderItem>(side);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, fries.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            fries.Size = Size.Large;
            Assert.Equal(Size.Large, fries.Size);
            fries.Size = Size.Medium;
            Assert.Equal(Size.Medium, fries.Size);
            fries.Size = Size.Small;
            Assert.Equal(Size.Small, fries.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            Assert.Empty(fries.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            fries.Size = size;
            Assert.Equal(price, fries.Price);
        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            fries.Size = size;
            Assert.Equal(calories, fries.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonbornWaffleFries fries = new DragonbornWaffleFries();
            fries.Size = size;
            Assert.Equal(name, fries.ToString());
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            DragonbornWaffleFries side = new DragonbornWaffleFries();

            Assert.PropertyChanged(side, "Size", () =>
            {
                side.Size = Size.Small;
            });

            Assert.PropertyChanged(side, "Size", () =>
            {
                side.Size = Size.Medium;
            });

            Assert.PropertyChanged(side, "Size", () =>
            {
                side.Size = Size.Large;
            });
        }
    }
}