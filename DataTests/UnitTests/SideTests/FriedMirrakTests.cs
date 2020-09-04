﻿/*
 * Author: Nathan Connor
 * Class: FriedMiraakTests.cs
 * Purpose: Test the FriedMiraak.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class FriedMiraakTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            FriedMiraak miraak = new FriedMiraak();
            Assert.Equal(Size.Small, miraak.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            FriedMiraak miraak = new FriedMiraak();
            miraak.Size = Size.Large;
            Assert.Equal(Size.Large, miraak.Size);
            miraak.Size = Size.Medium;
            Assert.Equal(Size.Medium, miraak.Size);
            miraak.Size = Size.Small;
            Assert.Equal(Size.Small, miraak.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            FriedMiraak miraak = new FriedMiraak();
            Assert.Empty(miraak.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.78)]
        [InlineData(Size.Medium, 2.01)]
        [InlineData(Size.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            FriedMiraak miraak = new FriedMiraak();
            miraak.Size = size;
            Assert.Equal(price, miraak.Price);
        }

        [Theory]
        [InlineData(Size.Small, 151)]
        [InlineData(Size.Medium, 236)]
        [InlineData(Size.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            FriedMiraak miraak = new FriedMiraak();
            miraak.Size = size;
            Assert.Equal(calories, miraak.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Fried Miraak")]
        [InlineData(Size.Medium, "Medium Fried Miraak")]
        [InlineData(Size.Large, "Large Fried Miraak")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            FriedMiraak miraak = new FriedMiraak();
            miraak.Size = size;
            Assert.Equal(name, miraak.ToString());
        }
    }
}