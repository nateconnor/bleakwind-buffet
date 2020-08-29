using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Sides
{
    class FriedMiraak
    {
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                    return 1.78;
                else if (Size == Size.Medium)
                    return 2.01;
                else
                    return 2.88;


            }
        }
        public List<String> SpecialInstructions
        {
            get
            {
                return SpecialInstructions;
            }
        }
        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                    return 151;
                else if (Size == Size.Medium)
                    return 236;
                else
                    return 306;

            }
        }

        public Size Size
        {
            get; set;
        } = Size.Small;


        public override string ToString()
        {
            return $"{Size} Fried Miraak";
        }
    }
}

