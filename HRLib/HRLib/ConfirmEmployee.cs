using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class ConfirmEmployee : Employee
    {

        private double basic;

        public double Basic
        {
            get
            {
                return basic;  
                
            }
           
            set 
            {
                basic = value;
                if (Basic >= 5000)
                {
                    basic = value;
                }
               else
                {
                    throw new BasicException("Basic is below 5000");
                }
            }
         

        }
        

        private string designation;

        public string Designation
        {
            get { return designation; } 
            set { designation = value; }    
        }

        

        public ConfirmEmployee()
        {
            Basic = 21000;
            Designation = "Software Developer";

        }

        public ConfirmEmployee(string name, string address, double basic, string designation):base(name,address)
        {
            Basic = basic;          
            Designation = designation;
        }

        public override string ToString() 
        {
            return base.ToString() + $"  Basic : {Basic} Designation : {Designation} ";
        }




        public override  double CalculateSalary()
        {

             double Hra, PF, Conv ,NetSalary;

            if (Basic >= 30000 )
            {
                Hra = Basic * 0.3;
                Conv = Basic * 0.3; ;
                PF = Basic * 0.1;
                NetSalary = Basic + Hra + Conv - PF;
               

            }
            else if(Basic >= 20000)
            {
                Hra = Basic* 0.2;
                Conv = Basic * 0.2;
                PF = Basic * 0.1;
                NetSalary = Basic + Hra + Conv - PF;

            }
            else 
            {
                Hra = Basic * 0.1;
                Conv = Basic * 0.1;
                PF = Basic * 0.1;
                NetSalary =  Basic + Hra + Conv - PF;

            }
            
            
            return NetSalary;

            

        }

       
    }
     
}


