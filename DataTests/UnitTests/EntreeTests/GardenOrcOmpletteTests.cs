/*
 * Author: Nathan Connor
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using System;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;



namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            GardenOrcOmelette entree = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(entree);
        }

        [Fact]
        public void ShouldBeOrderable()
        {
            GardenOrcOmelette entree = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(entree);
        }

        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette OrcOm = new GardenOrcOmelette();
            Assert.True(OrcOm.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette OrcOm = new GardenOrcOmelette();
            Assert.True(OrcOm.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette OrcOm = new GardenOrcOmelette();
            Assert.True(OrcOm.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette OrcOm = new GardenOrcOmelette();
            Assert.True(OrcOm.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette OrcOm = new GardenOrcOmelette();
            OrcOm.Broccoli = false;
            Assert.False(OrcOm.Broccoli);
            OrcOm.Broccoli = true;
            Assert.True(OrcOm.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette OrcOm = new GardenOrcOmelette();
            OrcOm.Mushrooms = false;
            Assert.False(OrcOm.Mushrooms);
            OrcOm.Mushrooms = true;
            Assert.True(OrcOm.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette OrcOm = new GardenOrcOmelette();
            OrcOm.Tomato = false;
            Assert.False(OrcOm.Tomato);
            OrcOm.Tomato = true;
            Assert.True(OrcOm.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette OrcOm = new GardenOrcOmelette();
            OrcOm.Cheddar = false;
            Assert.False(OrcOm.Cheddar);
            OrcOm.Cheddar = true;
            Assert.True(OrcOm.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette OrcOm = new GardenOrcOmelette();
            Assert.Equal(4.57, OrcOm.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette OrcOm = new GardenOrcOmelette();
            Assert.Equal(404, Convert.ToInt32(OrcOm.Calories));
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette OrcOm = new GardenOrcOmelette();
            OrcOm.Broccoli = includeBroccoli;
            OrcOm.Mushrooms = includeMushrooms;
            OrcOm.Tomato = includeTomato;
            OrcOm.Cheddar = includeCheddar;
           
            if (!includeBroccoli)
            {

                Assert.Contains("Hold Broccoli", OrcOm.SpecialInstructions);
            }
            if (!includeMushrooms)
            {

                Assert.Contains("Hold Mushrooms", OrcOm.SpecialInstructions);
            }
            if (!includeTomato)
            {

                Assert.Contains("Hold Tomato", OrcOm.SpecialInstructions);
            }
            if (!includeCheddar)
            {

                Assert.Contains("Hold Cheddar", OrcOm.SpecialInstructions);
            }
            
            else if (includeBroccoli && includeMushrooms && includeTomato && includeCheddar)
            {
                Assert.Empty(OrcOm.SpecialInstructions);

            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette OrcOm = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", OrcOm.ToString());
        }

        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            GardenOrcOmelette entree = new GardenOrcOmelette();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(entree);
        }

        [Fact]
        public void ChangingBroccoliNotifiesBroccoliProperty()
        {
            var entree = new GardenOrcOmelette();
            Assert.PropertyChanged(entree, "Broccoli", () =>
            {
                entree.Broccoli = true;
            });

            Assert.PropertyChanged(entree, "Broccoli", () =>
            {
                entree.Broccoli = false;
            });
        }

        [Fact]
        public void ChangingMushroomsNotifiesMushroomsProperty()
        {
            var entree = new GardenOrcOmelette();
            Assert.PropertyChanged(entree, "Mushrooms", () =>
            {
                entree.Mushrooms = true;
            });

            Assert.PropertyChanged(entree, "Mushrooms", () =>
            {
                entree.Mushrooms = false;
            });
        }

        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            var entree = new GardenOrcOmelette();
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
        public void ChangingCheddarNotifiesCheddarProperty()
        {
            var entree = new GardenOrcOmelette();
            Assert.PropertyChanged(entree, "Cheddar", () =>
            {
                entree.Cheddar = true;
            });

            Assert.PropertyChanged(entree, "Cheddar", () =>
            {
                entree.Cheddar = false;
            });
        }
    }
}