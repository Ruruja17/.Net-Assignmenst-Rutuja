using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public abstract class Employee
    {

        private int empNo;
        public int EmpNo
        {
            get { return empNo; }
            set { empNo = value; }
        }

        private string typeEmployee;
        public string TypeEmployee
        {
            get { return typeEmployee; }
            set { typeEmployee = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }    
                set { name = value; }


        }

        private string address;

        public string Address
        {
            get { return address; } 
            set { address = value; }
        }

        public Employee()
        {
            Name = "Rutuja";
            Address = " Bhandup";
            count++;
            empNo = count;
          


        }

        public Employee(string name, string address) : this()
        {
            Name = name;
            Address = address;
            EmpNo = empNo;
           
        }

        
        public abstract double CalculateSalary();

        public override string ToString()
        {
            return String.Format($" EmpNo :  {EmpNo} Name : {Name} Address : {Address} TypeOfEmployee : {TypeEmployee}");
        }

        private static int count;
        public int Count
        {
            get { return count; }
            private set { count = value; }


        }
    } 
}
