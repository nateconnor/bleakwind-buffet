using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Sides
{
    class DragonbornWaffleFries
    {
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                    return .42;
                else if (Size == Size.Medium)
                    return .76;
                else
                    return .96;


            }
        }

        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                    return 77;
                else if (Size == Size.Medium)
                    return 89;
                else
                    return 100;

            }
        }
        public List<String> SpecialInstructions
        {
            get
            {
                return SpecialInstructions;
            }
        }


        public Size Size
        {
            get; set;
        } = Size.Small;


        public override string ToString()
        {
            return $"{Size} Dragonborn Waffle Fries";
        }
    }
}
