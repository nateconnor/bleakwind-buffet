/*
 * Author: Nathan Connor
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System;


namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            SmokehouseSkeleton entree = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(entree);
        }

        [Fact]
        public void ShouldBeOrderable()
        {
            SmokehouseSkeleton entree = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(entree);
        }

        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton skel = new SmokehouseSkeleton();
            Assert.True(skel.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton skel = new SmokehouseSkeleton();
            Assert.True(skel.Egg  );
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton skel = new SmokehouseSkeleton();
            Assert.True(skel.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton skel = new SmokehouseSkeleton();
            Assert.True(skel.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton skel = new SmokehouseSkeleton();
            skel.SausageLink = false;
            Assert.False(skel.SausageLink);
            skel.SausageLink = true;
            Assert.True(skel.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton skel = new SmokehouseSkeleton();
            skel.Egg = false;
            Assert.False(skel.Egg);
            skel.Egg = true;
            Assert.True(skel.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton skel = new SmokehouseSkeleton();
            skel.HashBrowns = false;
            Assert.False(skel.HashBrowns);
            skel.HashBrowns = true;
            Assert.True(skel.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton skel = new SmokehouseSkeleton();
            skel.Pancake = false;
            Assert.False(skel.Pancake);
            skel.Pancake = true;
            Assert.True(skel.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton skel = new SmokehouseSkeleton();
            Assert.Equal(5.62, skel.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton skel = new SmokehouseSkeleton();
            Assert.Equal(602, Convert.ToInt32(skel.Calories));
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton skel = new SmokehouseSkeleton();
            skel.SausageLink = includeSausage;
            skel.Egg = includeEgg;
            skel.HashBrowns = includeHashbrowns;
            skel.Pancake = includePancake;
           
            if (!includeSausage)
            {

                Assert.Contains("Hold sausage", skel.SpecialInstructions);
            }
            if (!includeEgg)
            {

                Assert.Contains("Hold eggs", skel.SpecialInstructions);
            }
            if (!includeHashbrowns)
            {

                Assert.Contains("Hold hash browns", skel.SpecialInstructions);
            }
            if (!includePancake)
            {

                Assert.Contains("Hold pancakes", skel.SpecialInstructions);
            }
           
            else if (includeSausage && includeEgg && includeHashbrowns && includePancake)
            {
                Assert.Empty(skel.SpecialInstructions);

            }


        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton skel = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", skel.ToString());
        }
    }
}