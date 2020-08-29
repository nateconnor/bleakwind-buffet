using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Sides
{
    class VokunSalad
    {
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                    return .93;
                else if (Size == Size.Medium)
                    return 1.28;
                else
                    return 1.82;


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
                    return 41;
                else if (Size == Size.Medium)
                    return 52;
                else
                    return 73;

            }
        }

        public Size Size
        {
            get; set;
        } = Size.Small;


        public override string ToString()
        {
            return $"{Size} Vokun Salad";
        }
    }
}

