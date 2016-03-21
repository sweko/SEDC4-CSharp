using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqClasses
{
    public class RectangleField
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int Area
        {
            get
            {
                return Width * Height;
            }
        }

        public int Perimeter
        {
            get
            {
                return 2*(Width + Height);
            }
        }

        public override string ToString()
        {
            return $"Width: {Width}; Height: {Height}";
        }

    }
}
