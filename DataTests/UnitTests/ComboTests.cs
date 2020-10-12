
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class ComboTests
    {
        [Fact]
        public void AddingEntreeNotifiesProperties()
        {
            Combo c = new Combo();
            Assert.PropertyChanged(c, "Price", () =>
            {
                c.entree = new BriarheartBurger();
            });

            Assert.PropertyChanged(c, "SpecialInstructions", () =>
            {
                c.entree = new ThalmorTriple();
            });
            Assert.PropertyChanged(c, "Calories", () =>
            {
                c.entree = new SmokehouseSkeleton();
            });
            

        }

        [Fact]
        public void AddingDrinkNotifiesProperties()
        {
            Combo c = new Combo();
            Assert.PropertyChanged(c, "Price", () =>
            {
                c.drink = new AretinoAppleJuice();
            });

            Assert.PropertyChanged(c, "SpecialInstructions", () =>
            {
                c.drink = new SailorSoda();
            });
            Assert.PropertyChanged(c, "Calories", () =>
            {
                c.drink = new MarkarthMilk();
            });


        }


        [Fact]
        public void AddingSideNotifiesProperties()
        {
            Combo c = new Combo();
            Assert.PropertyChanged(c, "Price", () =>
            {
                c.side = new VokunSalad();
            });

            Assert.PropertyChanged(c, "SpecialInstructions", () =>
            {
                c.side = new MadOtarGrits();
            });
            Assert.PropertyChanged(c, "Calories", () =>
            {
                c.side = new DragonbornWaffleFries();
            });


        }

        [Fact]
        public void PriceIsCorrect()
        {
            Combo c = new Combo();
            BriarheartBurger burg = new BriarheartBurger();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            c.entree = burg;
            c.drink = aj;
            c.side = dw;
            Assert.Equal(burg.Price + aj.Price + dw.Price - 1, c.Price);

        }

        [Fact]
        public void CaloriesIsCorrect()
        {
            Combo c = new Combo();
            BriarheartBurger burg = new BriarheartBurger();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            c.entree = burg;
            c.drink = aj;
            c.side = dw;
            Assert.Equal(burg.Calories + aj.Calories + dw.Calories, c.Calories);

        }

        [Fact]
        public void ChangingItemPriceChangesComboPrice()
        {
            Combo c = new Combo();
            BriarheartBurger burg = new BriarheartBurger();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            c.entree = burg;
            c.drink = aj;
            c.side = dw;
            
            Assert.PropertyChanged(c, "Price", () =>
            {
                c.drink.Size = Size.Medium;
            });
            Assert.PropertyChanged(c, "Calories", () =>
            {
                c.drink.Size = Size.Large;
            });

            // Assert.Equal(burg.Price + aj.Price + dw.Price - 1, c.Price);

        }


        [Fact]
        public void ChangingSpecialInstructions()
        {
            Combo c = new Combo();
            BriarheartBurger burg = new BriarheartBurger();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            c.entree = burg;
            c.drink = aj;
            c.side = dw;

            Assert.PropertyChanged(c, "SpecialInstructions", () =>
            {
                
                    aj.Ice = true;
                c.drink = aj;


            });

            // Assert.Equal(burg.Price + aj.Price + dw.Price - 1, c.Price);

        }

    }
}
