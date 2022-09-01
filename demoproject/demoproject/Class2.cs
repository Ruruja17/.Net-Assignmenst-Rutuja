using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    internal class Class2
    {
        //static void Main(string[] args)
        //{
        //    int Num1;
        //    int val1;
        //    int val2;
            

        //    int result;

        //    Console.WriteLine("Enter  your choice : \n1.  ADD\n2.  SUBTRACT\n3.  MULTIPLY\n4.  DIVISION");

        //    Num1 = int.Parse(Console.ReadLine());
        //    Console.WriteLine(Num1);
        //    Console.WriteLine("Enter  first value: ");
        //    val1 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter second value: ");
        //    val2 = int.Parse(Console.ReadLine());

        //    switch (Num1)
            //{
            //    case 1:
            //        result = Addition(val1, val2);
            //        Console.WriteLine(result);
            //        break;

            //    case 2:
            //        result = Subtract(val1, val2);
            //        Console.WriteLine(result);
            //        break;
                
            //    case 3:
            //        result = Multiply(val1, val2);
            //        Console.WriteLine(result);
            //        break;

            //    case 4:
            //        result = Division(val1, val2);
            //        Console.WriteLine(result);
            //        break;

            //    default:
            //        break;


            //}
            


        //    Console.ReadLine();
            
       
        //}
        static int Addition(int Val1, int val2)
        {
            return Val1 + val2;

        }
        static int Subtract(int Val1, int val2)
        {
            return Val1 - val2;

        }
        static int Multiply(int Val1, int val2)
        {
            return Val1 * val2;

        }
        static int Division(int Val1, int val2)
        {
            return Val1 / val2;

        }
    }
    


}
