/*
 * Author: Nathan Connor
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System;


namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            ThugsTBone entree = new ThugsTBone();
            Assert.IsAssignableFrom<Entree>(entree);
        }

        [Fact]
        public void ShouldBeOrderable()
        {
            ThugsTBone entree = new ThugsTBone();
            Assert.IsAssignableFrom<IOrderItem>(entree);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone tbone = new ThugsTBone();
            Assert.Equal(6.44, tbone.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsTBone tbone = new ThugsTBone();
            Assert.Equal(982, Convert.ToInt32(tbone.Calories));
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone tbone = new ThugsTBone();
            Assert.Empty(tbone.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTBone tbone = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", tbone.ToString());
        }
    }
}