/*
 * Author: Nathan Connor
 * Class: Menu.cs
 * Purpose: A class to represent the entire menu
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System.Collections;
using System.IO;
using System.Linq;
 

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// A class to represent the entire menu at bleakwind buffet
    /// </summary>
   public static class Menu
    {

        public static string[] OrderTypes
        {
            get => new string[]
            {
            "Entree",
            "Drink",
            "Side"
           
            };
        }

        /// <summary>
        /// Gets all possible entrees on the menu
        /// </summary>
        /// <returns>A list of all possible entrees on the menu </returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
            entrees.Add(new BriarheartBurger());
            entrees.Add(new DoubleDraugr());
            entrees.Add(new GardenOrcOmelette());
            entrees.Add(new PhillyPoacher());
            entrees.Add(new SmokehouseSkeleton());
            entrees.Add(new ThalmorTriple());
            entrees.Add(new ThugsTBone());
            return entrees;
        }

        /// <summary>
        /// Gets all possible sides on the menu
        /// </summary>
        /// <returns>A list of all possible sides on the menu </returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();

            //small
            sides.Add(new DragonbornWaffleFries());
            sides.Add(new FriedMiraak());
            sides.Add(new MadOtarGrits());
            sides.Add(new VokunSalad());

            //medium
            DragonbornWaffleFries medD = new DragonbornWaffleFries();
            medD.Size = Size.Medium;
            sides.Add(medD);

            FriedMiraak medF = new FriedMiraak();
            medF.Size = Size.Medium;
            sides.Add(medF);

            MadOtarGrits medM = new MadOtarGrits();
            medM.Size = Size.Medium;
            sides.Add(medM);

            VokunSalad medV = new VokunSalad();
            medV.Size = Size.Medium;
            sides.Add(medV);

            //large
            DragonbornWaffleFries largeD = new DragonbornWaffleFries();
            largeD.Size = Size.Large;
            sides.Add(largeD);

            FriedMiraak largeF = new FriedMiraak();
            largeF.Size = Size.Large;
            sides.Add(largeF);

            MadOtarGrits largeM = new MadOtarGrits();
            largeM.Size = Size.Large;
            sides.Add(largeM);

            VokunSalad largeV = new VokunSalad();
            largeV.Size = Size.Large;
            sides.Add(largeV);



            return sides;

        }

        /// <summary>
        /// Gets all possible drinks on the menu
        /// </summary>
        /// <returns>A list of all possible drinks on the menu </returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List < IOrderItem > drinks= new List<IOrderItem>();

            drinks.Add(new AretinoAppleJuice());
            drinks.Add(new CandlehearthCoffee());
            drinks.Add(new CandlehearthCoffee() { Decaf = true });
            drinks.Add(new MarkarthMilk());
            drinks.Add(new WarriorWater());

            //medium
            AretinoAppleJuice medA = new AretinoAppleJuice();
            medA.Size = Size.Medium;
            drinks.Add(medA);

            CandlehearthCoffee medC = new CandlehearthCoffee();
            medC.Size = Size.Medium;
            drinks.Add(medC);
            drinks.Add(new CandlehearthCoffee() { Decaf = true , Size = Size.Medium});

            MarkarthMilk medM = new MarkarthMilk();
            medM.Size = Size.Medium;
            drinks.Add(medM);


            WarriorWater medW = new WarriorWater();
            medW.Size = Size.Medium;
            drinks.Add(medW);

            //large
            AretinoAppleJuice largeA = new AretinoAppleJuice();
            largeA.Size = Size.Large;
            drinks.Add(largeA);

            CandlehearthCoffee largeC = new CandlehearthCoffee();
            largeC.Size = Size.Large;
            drinks.Add(largeC);
            drinks.Add(new CandlehearthCoffee() { Decaf = true, Size = Size.Large });

            MarkarthMilk largeM = new MarkarthMilk();
            largeM.Size = Size.Large;
            drinks.Add(largeM);


            WarriorWater largeW = new WarriorWater();
            largeW.Size = Size.Large;
            drinks.Add(largeW);

            //SailorSodas
            //small
            drinks.Add(new SailorSoda()); //small cherry

            SailorSoda s1 = new SailorSoda();
            s1.Flavor = SodaFlavor.Blackberry;
            drinks.Add(s1);

            SailorSoda s2 = new SailorSoda();
            s2.Flavor = SodaFlavor.Grapefruit;
            drinks.Add(s2);

            SailorSoda s3 = new SailorSoda();
            s3.Flavor = SodaFlavor.Lemon;
            drinks.Add(s3);

            SailorSoda s4 = new SailorSoda();
            s4.Flavor = SodaFlavor.Peach;
            drinks.Add(s4);

            SailorSoda s5 = new SailorSoda();
            s5.Flavor = SodaFlavor.Watermelon;
            drinks.Add(s5);

            //medium
            SailorSoda s6 = new SailorSoda(); //medium cherry
            s6.Size = Size.Medium;
            drinks.Add(s6);

            SailorSoda s7 = new SailorSoda();
            s7.Size = Size.Medium;
            s7.Flavor = SodaFlavor.Blackberry;
            drinks.Add(s7);

            SailorSoda s8 = new SailorSoda();
            s8.Size = Size.Medium;
            s8.Flavor = SodaFlavor.Grapefruit;
            drinks.Add(s8);

            SailorSoda s9 = new SailorSoda();
            s9.Size = Size.Medium;
            s9.Flavor = SodaFlavor.Lemon;
            drinks.Add(s9);

            SailorSoda s10 = new SailorSoda();
            s10.Size = Size.Medium;
            s10.Flavor = SodaFlavor.Peach;
            drinks.Add(s10);

            SailorSoda s11 = new SailorSoda();
            s11.Size = Size.Medium;
            s11.Flavor = SodaFlavor.Watermelon;
            drinks.Add(s11);

            //large
            SailorSoda s12 = new SailorSoda(); //Large cherry
            s12.Size = Size.Large;
            drinks.Add(s12);

            SailorSoda s13 = new SailorSoda();
            s13.Size = Size.Large;
            s13.Flavor = SodaFlavor.Blackberry;
            drinks.Add(s13);

            SailorSoda s14 = new SailorSoda();
            s14.Size = Size.Large;
            s14.Flavor = SodaFlavor.Grapefruit;
            drinks.Add(s14);

            SailorSoda s15 = new SailorSoda();
            s15.Size = Size.Large;
            s15.Flavor = SodaFlavor.Lemon;
            drinks.Add(s15);

            SailorSoda s16 = new SailorSoda();
            s16.Size = Size.Large;
            s16.Flavor = SodaFlavor.Peach;
            drinks.Add(s16);

            SailorSoda s17 = new SailorSoda();
            s17.Size = Size.Large;
            s17.Flavor = SodaFlavor.Watermelon;
            drinks.Add(s17);

            return drinks;

        }

        /// <summary>
        /// Gets all possible orders on the menu
        /// </summary>
        /// <returns>A list of all possible orderable items on the menu </returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> fullMenu = new List<IOrderItem>();
            fullMenu.Add(new BriarheartBurger());
            fullMenu.Add(new DoubleDraugr());
            fullMenu.Add(new GardenOrcOmelette());
            fullMenu.Add(new PhillyPoacher());
            fullMenu.Add(new SmokehouseSkeleton());
            fullMenu.Add(new ThalmorTriple());
            fullMenu.Add(new ThugsTBone());


            fullMenu.Add(new DragonbornWaffleFries());
            fullMenu.Add(new FriedMiraak());
            fullMenu.Add(new MadOtarGrits());
            fullMenu.Add(new VokunSalad());

            //medium
            DragonbornWaffleFries medD = new DragonbornWaffleFries();
            medD.Size = Size.Medium;
            fullMenu.Add(medD);

            FriedMiraak medF = new FriedMiraak();
            medF.Size = Size.Medium;
            fullMenu.Add(medF);

            MadOtarGrits medM = new MadOtarGrits();
            medM.Size = Size.Medium;
            fullMenu.Add(medM);

            VokunSalad medV = new VokunSalad();
            medV.Size = Size.Medium;
            fullMenu.Add(medV);

            //large
            DragonbornWaffleFries largeD = new DragonbornWaffleFries();
            largeD.Size = Size.Large;
            fullMenu.Add(largeD);

            FriedMiraak largeF = new FriedMiraak();
            largeF.Size = Size.Large;
            fullMenu.Add(largeF);

            MadOtarGrits largeM = new MadOtarGrits();
            largeM.Size = Size.Large;
            fullMenu.Add(largeM);

            VokunSalad largeV = new VokunSalad();
            largeV.Size = Size.Large;
            fullMenu.Add(largeV);


            fullMenu.Add(new AretinoAppleJuice());
            fullMenu.Add(new CandlehearthCoffee());
            fullMenu.Add(new CandlehearthCoffee() { Decaf = true });

            fullMenu.Add(new MarkarthMilk());
            fullMenu.Add(new WarriorWater());

            //medium
            AretinoAppleJuice medA = new AretinoAppleJuice();
            medA.Size = Size.Medium;
            fullMenu.Add(medA);

            CandlehearthCoffee medC = new CandlehearthCoffee();
            medC.Size = Size.Medium;
            fullMenu.Add(medC);
            fullMenu.Add(new CandlehearthCoffee() { Decaf = true, Size = Size.Medium });


            MarkarthMilk medMilk = new MarkarthMilk();
            medMilk.Size = Size.Medium;
            fullMenu.Add(medMilk);


            WarriorWater medW = new WarriorWater();
            medW.Size = Size.Medium;
            fullMenu.Add(medW);

            //large
            AretinoAppleJuice largeA = new AretinoAppleJuice();
            largeA.Size = Size.Large;
            fullMenu.Add(largeA);

            CandlehearthCoffee largeC = new CandlehearthCoffee();
            largeC.Size = Size.Large;
            fullMenu.Add(largeC);
            fullMenu.Add(new CandlehearthCoffee() { Decaf = true, Size = Size.Large });


            MarkarthMilk largeMilk = new MarkarthMilk();
            largeMilk.Size = Size.Large;
            fullMenu.Add(largeMilk);


            WarriorWater largeW = new WarriorWater();
            largeW.Size = Size.Large;
            fullMenu.Add(largeW);

            //SailorSodas
            //small
            fullMenu.Add(new SailorSoda()); //small cherry

            SailorSoda s1 = new SailorSoda();
            s1.Flavor = SodaFlavor.Blackberry;
            fullMenu.Add(s1);

            SailorSoda s2 = new SailorSoda();
            s2.Flavor = SodaFlavor.Grapefruit;
            fullMenu.Add(s2);

            SailorSoda s3 = new SailorSoda();
            s3.Flavor = SodaFlavor.Lemon;
            fullMenu.Add(s3);

            SailorSoda s4 = new SailorSoda();
            s4.Flavor = SodaFlavor.Peach;
            fullMenu.Add(s4);

            SailorSoda s5 = new SailorSoda();
            s5.Flavor = SodaFlavor.Watermelon;
            fullMenu.Add(s5);

            //medium
            SailorSoda s6 = new SailorSoda(); //medium cherry
            s6.Size = Size.Medium;
            fullMenu.Add(s6);

            SailorSoda s7 = new SailorSoda();
            s7.Size = Size.Medium;
            s7.Flavor = SodaFlavor.Blackberry;
            fullMenu.Add(s7);

            SailorSoda s8 = new SailorSoda();
            s8.Size = Size.Medium;
            s8.Flavor = SodaFlavor.Grapefruit;
            fullMenu.Add(s8);

            SailorSoda s9 = new SailorSoda();
            s9.Size = Size.Medium;
            s9.Flavor = SodaFlavor.Lemon;
            fullMenu.Add(s9);

            SailorSoda s10 = new SailorSoda();
            s10.Size = Size.Medium;
            s10.Flavor = SodaFlavor.Peach;
            fullMenu.Add(s10);

            SailorSoda s11 = new SailorSoda();
            s11.Size = Size.Medium;
            s11.Flavor = SodaFlavor.Watermelon;
            fullMenu.Add(s11);

            //large
            SailorSoda s12 = new SailorSoda(); //Large cherry
            s12.Size = Size.Large;
            fullMenu.Add(s12);

            SailorSoda s13 = new SailorSoda();
            s13.Size = Size.Large;
            s13.Flavor = SodaFlavor.Blackberry;
            fullMenu.Add(s13);

            SailorSoda s14 = new SailorSoda();
            s14.Size = Size.Large;
            s14.Flavor = SodaFlavor.Grapefruit;
            fullMenu.Add(s14);

            SailorSoda s15 = new SailorSoda();
            s15.Size = Size.Large;
            s15.Flavor = SodaFlavor.Lemon;
            fullMenu.Add(s15);

            SailorSoda s16 = new SailorSoda();
            s16.Size = Size.Large;
            s16.Flavor = SodaFlavor.Peach;
            fullMenu.Add(s16);

            SailorSoda s17 = new SailorSoda();
            s17.Size = Size.Large;
            s17.Flavor = SodaFlavor.Watermelon;
            fullMenu.Add(s17);

            return fullMenu;
        }

        /// <summary>
        /// filters the items by the food category they are in
        /// </summary>
        /// <param name="items"></param>
        /// <param name="categories"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, IEnumerable<string> categories)
        {
            // If no filter is specified, just return the provided collection
            if (categories == null || categories.Count() == 0) return items;

            // Filter the supplied collection of movies
            List<IOrderItem> results = new List<IOrderItem>();
            foreach (IOrderItem item in items)
            {
                if (item.Type != null && categories.Contains(item.Type))
                {
                    results.Add(item);
                }
            }

            return results;
        }

        /// <summary>
        /// Filters the items by calories
        /// </summary>
        /// <param name="items"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, int? min, int? max)

        {
            if (min == null && max == null) return items; // TODO: Filter movies

            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;


            }

            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in items)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// filters the items by price
        /// </summary>
        /// <param name="items"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items; // TODO: Filter movies

            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;


            }

            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in items)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// filters the items by search terms
        /// </summary>
        /// <param name="items"></param>
        /// <param name="terms"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> items, string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            if (terms == null)
                return items;
            foreach (IOrderItem item in items)
            {
                if (item.ToString().ToLower().Contains(terms.ToLower()))
                {
                    results.Add(item);
                }
            }
            return results;
        }


    }


}
