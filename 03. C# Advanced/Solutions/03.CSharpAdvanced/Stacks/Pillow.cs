using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    public class Pillow
    {
        public Pillow(string color, string kind, string size)
        {
            this.Color = color;
            this.Kind = kind;
            this.Size = size;
        }
        public string Color { get; set; }

        public string Kind { get; set; }

        public string Size { get; set; }
    }
}
