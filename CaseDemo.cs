
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    internal class switchcase
    {
        //static void Main(string[] args) 
        //{ 
        //    Console.WriteLine("Enter a month to know which season is :"); 
        //    int Num1; 
        //    Num1= int.Parse(Console.ReadLine()); 

        //    string season = Season(Num1); 
        //    Console.WriteLine(season);
        //    Console.ReadLine(); 
        //}

        static string Season(int Num1)
        {
            switch (Num1)
            {
                case 1:
                    return "Winter Season";
                    break;

                case 2:
                    return "Winter Season"; 
                    break;

                case 3:
                    return "Summer Season";
                    break;

                case 4:
                    return "Summer Season";
                    break;

                case 5: 
                    return "Summer Season"; 
                    break;

                case 6: 
                    return "Monsoon Season";
                    break;

                case 7: 
                    return "Monsoon Season"; 
                    break;

                case 8: 
                    return "Monsoon Season"; 
                    break;

                case 9: 
                    return "Monsoon Season"; 
                    break;

                case 10:
                    return "Summer Season"; 
                    break;

                case 11: 
                    return "Winter Season"; 
                    break;

                case 12: 
                    return "Winter Season";
                    break;

                default: 
                    return "Invalid Value";
                    break;
            }

        }
    }
}

