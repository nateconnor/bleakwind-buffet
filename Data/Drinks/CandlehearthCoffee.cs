using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Drinks
{
    class CandlehearthCoffee
    {
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                    return .75;
                else if (Size == Size.Medium)
                    return 1.25;
                else
                    return 1.75;


            }
        }

        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                    return 7;
                else if (Size == Size.Medium)
                    return 10;
                else
                    return 20;

            }
        }

        public Size Size
        {
            get; set;
        } = Size.Small;

       

        public bool Ice , RoomForCream, Decaf = false;

        public List<String> SpecialInstructions
        {
            get
            {
                if (Ice)
                {
                    SpecialInstructions.Add("Add ice");
                }
                if (RoomForCream)
                {
                    SpecialInstructions.Add("Add cream");
                }
                return SpecialInstructions;
            }
        }



        public override string ToString()
        {
            if(Decaf)
            return $"{Size} Candlehearth Coffee";
            else
                return $"{Size} Decaf Candlehearth Coffee";

        }
    }
}
}
