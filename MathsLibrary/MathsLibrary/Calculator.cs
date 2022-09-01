using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsLibrary
{
    public class Calculator
    {
        private int num1;

        public int Num1
        {
            get { return num1; }
            set { num1 = value; }
        }

        private int num2;

        public int Num2
        {
            get { return num2; }
            set { num2 = value; }
        }

        public int Addition()
        {
            return Num1 + Num2;
        }
        public int Substraction()
        {
            return Num1 - Num2;
        }

        public int Multiplication()
        {
            return Num1 * Num2;
        }

        public int Division()
        {
            return Num1 / Num2;
        }

    }
}
