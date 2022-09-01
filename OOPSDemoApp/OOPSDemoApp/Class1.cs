using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemoApp
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator); //invoke Tostring() method

            calculator.Num1 = 20;
            calculator.Num2 = 30;

            int result = calculator.Addition();
            

            Console.WriteLine("result =" + result);


            Calculator calculator1 = new Calculator();
            Console.WriteLine(calculator1);
            int result1 = calculator.Substraction();

           
            Console.WriteLine("result =" + result1);

            Calculator calculator2 = new Calculator();
            Console.WriteLine(calculator2);
            int result2 = calculator.Multiplication();

            
            Console.WriteLine("result =" + result2);


            Calculator calculator3 = new Calculator();
            Console.WriteLine(calculator3);
            int result3 = calculator.Division();


            Console.WriteLine("result =" + result3);



            Console.ReadLine();


        }
    }
}
