using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapxulyanhso
{
    class checkValueColor
    {
        public static int validateColor(int value)
        {
            if (value < 0)
            {
                value *= -1;
            }
            return value;
        }
    }
}
