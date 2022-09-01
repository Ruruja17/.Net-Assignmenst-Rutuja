using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    internal class Class1
    {
        //static void Main(string[] args)

        //{

        //    string choice;

        //    do
        //    {
                


        //        Console.WriteLine("Enter a number");
        //        int Num1 = int.Parse(Console.ReadLine());
                
        //        Console.WriteLine(OddorEven(Num1));
        //        Console.WriteLine("do you wnat to continue? 'y' or 'n'");
        //        choice = Console.ReadLine();

        //    } while (choice == "y");


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
