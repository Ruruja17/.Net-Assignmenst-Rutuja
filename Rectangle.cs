using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib
{
    public class Rectangle
    {
        private int length;

        public int Length
        {
            get { return length; }
            set { length = value; }

        }

        private int width;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int GetArea()
        {
            return Length * Width;
        }

        public override string ToString()
        {
            return String.Format($"Length : {Length}  Width :{Width}");
        }
    }
}
