using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLib;

namespace ABCDCorp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------Confirmed Employee-------------");

            
           

            try
            {
                ConfirmEmployee confirmEmployee = new ConfirmEmployee();
                Console.WriteLine(confirmEmployee);

                ConfirmEmployee confirmEmployee1 = new ConfirmEmployee("Bharat", "Bhandup", 1000, "Software Developer");
                Console.WriteLine(confirmEmployee1);

                Console.WriteLine(confirmEmployee1.CalculateSalary());

            }
            catch(BasicException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("---------------Trainee Employee-------------");
            Trainee trainee = new Trainee("AAshu", "Thane",20,1200);
            Console.WriteLine(trainee);

           


            Console.WriteLine(trainee.CalculateSalary());
         



            Console.ReadLine();
        }
    }
}
