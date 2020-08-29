using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class SmokehouseSkeleton
    {
        public double Price
        {
            get
            {
                return 5.62;
            }
        }

        public uint Calories
        {
            get
            {
                return 602;
            }
        }

        public List<String> SpecialInstructions
        {
            get
            {
                if (!SausageLink)
                {
                    SpecialInstructions.Add("Hold sausage");
                }
                if (!Egg)
                {
                    SpecialInstructions.Add("Hold eggs");
                }
                if (!HashBrowns)
                {
                    SpecialInstructions.Add("Hold hash browns");
                }
                if (!Pancake)
                {
                    SpecialInstructions.Add("Hold pancakes");
                }
                
                return SpecialInstructions;
            }

        }

        public bool SausageLink, Egg, HashBrowns, Pancake = true;

        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
