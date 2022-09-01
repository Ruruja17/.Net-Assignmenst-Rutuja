using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// PascalCase: ProjName, ClassName, MethodName, PropertyName, EventName
//cascalcase
namespace OOPSDemoApp
{
    internal class Rectangle
    {

        //member field and methods
        //field


        


        private int length; //camelCase

        public int Length  //PascalCase
        {
            get { return length; } //reading
            set { length = value; } //assignment
        }

        private int width;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        #region Methods

        public int GetArea()
        {
            return Length * Width;
        }
        #endregion

        public Rectangle()
        {
            Length = 1;
            width = 1;
            count++;
        }
        //parametarized constructor
        public override string ToString()

        {
            // Traditional way
            //return "Length = " + Length + "Width = " + Width;

            //string formated 
            // return String.Format("Length = {0} Width = {1}", Length, Width);

            return String.Format($"Length {Length} Width:{width}");
        }


        public Rectangle(int _length, int _width) :this()
        {
            Length = _length;
            Width = _width;
        }

        #region static members

        private static int count;

        public static int counter
        {
            get { return count; }
        }

        //static constructor

        static Rectangle()
        {
            count = 1000;
        }

        #endregion
    }
}


