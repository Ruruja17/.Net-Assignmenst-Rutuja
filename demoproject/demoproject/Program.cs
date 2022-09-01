using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    internal class Program
    {
        //static void Main(string[] args)
        //{


        //    int Num1 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter a number");



        //    Console.WriteLine(OddorEven(Num1));


        //    Console.ReadLine();
        //}
        static string OddorEven(int Num1)
        {

            if (Num1 % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "odd";
            }

        }

    }
}