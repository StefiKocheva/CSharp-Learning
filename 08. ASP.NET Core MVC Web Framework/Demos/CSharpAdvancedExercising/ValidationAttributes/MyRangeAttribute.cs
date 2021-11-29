using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationAttributes
{
    class MyRangeAttribute : Attribute
    {
        private int minValue;
        private int maxValue;

        public int MinValue { get; set; }
        public int MaxValue { get; set; }
    }
}
