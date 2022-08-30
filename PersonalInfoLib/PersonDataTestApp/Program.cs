using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalInfoLib;

namespace PersonDataTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Fname = "Rutuja";
            person.Lname = "Jadhav";
            person.Email = "rutujajadhav175200@gmail.com";
            person.DateOfBirth = Convert.ToDateTime("05/17/2000");

            Person person1 = new Person();
            person1.StartDate = Convert.ToDateTime("12/22");
            person1.EndDate = Convert.ToDateTime("01/19");


            Console.WriteLine(person);
            Console.WriteLine("Is person is Adult ? = " + person.IsAdult());
            Console.WriteLine("Is persons birthday ? = " + person.IsBirthdayToday());
            Console.WriteLine("Sunsign of Person  ? = " + person.SunSign());
            Console.ReadLine();
        }
      
    }
}
