using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class Trainee : Employee
    {


        private int noOfDays;

        public int NoOfDays
        {
            get { return noOfDays; }
            set { noOfDays = value; }
        }

        private int ratePerDay;

        public int RatePerDay
        {
            get { return ratePerDay; }
            set { ratePerDay = value; }
        }

        public Trainee()
        {
            NoOfDays = 30;
            RatePerDay = 1500;
        }

        public Trainee(string name, string address, int noOfDays, int ratePerDay) : base(name, address)
        {
            NoOfDays = noOfDays;
            RatePerDay = ratePerDay;
        }

        public override double CalculateSalary()
        {
          double NetSalary = NoOfDays * RatePerDay;
            return NetSalary;
        }

        public override string ToString()
        {
            return base.ToString() + $" NoOfDays : {NoOfDays} Rate: {RatePerDay}";
        }
    }

}