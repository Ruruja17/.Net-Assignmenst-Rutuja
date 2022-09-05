using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLib;

namespace HRApp
{
    public class Program1
    {
        static void Main(string[] args)
        {
            
            //List<ConfirmEmployee> EmployeeList = new List<ConfirmEmployee>();
            //EmployeeList.Add(new ConfirmEmployee { Name = "Diya", Address = "Thane", TypeEmployee = "ConfirmEmployee" });
            //EmployeeList.Add(new ConfirmEmployee { Name = "Ansh", Address = "Mulund", TypeEmployee = "ConfirmEmployee" });
            //List<Trainee> EmployeeList1 = new List<Trainee>();

            //EmployeeList1.Add(new Trainee { Name = "Sanskar", Address = "Mumbai Central", TypeEmployee = "Trainee" });
            //EmployeeList1.Add(new Trainee { Name = "Rudra", Address = "kalyan", TypeEmployee = " Trainee" });

            ConfirmEmployee Employee1 = new ConfirmEmployee() { Name = "Diya", Address = "Thane", TypeEmployee = "ConfirmEmployee" };
            ConfirmEmployee Employee2 = new ConfirmEmployee() { Name = "Ansh", Address = "Mulund", TypeEmployee = "ConfirmEmployee" };
            Trainee Employee3 = new Trainee(){ Name = "Sanskar", Address = "Mumbai Central", TypeEmployee = "Trainee"  };
            Trainee Employee4 = new Trainee() { Name = "Rudra", Address = "kalyan", TypeEmployee = " Trainee" };
            ConfirmEmployee confirmEmployee = new ConfirmEmployee() ;
           


            List<Employee> EmployeeList = new List<Employee>
            {
               
                Employee1,
                Employee2,
                Employee3,
                Employee4, 
                confirmEmployee


            };

            string choice;

            do
            {
                int temp = 0;
                Console.WriteLine("Select Your Choice : \n 1.Display Details of All Employees. \n 2. Display Employees by EmpNo.");


                int choiceNum = int.Parse(Console.ReadLine());
                Console.WriteLine(choiceNum);
                switch (choiceNum)
                {
                    
                    case 1:



                        //for(int i =0; i < EmployeeList.Count; i++)
                        //{

                        //    Console.WriteLine(EmployeeList[i].ToString());
                        //}

                        foreach (Employee emp in EmployeeList)
                        {
                            Console.WriteLine(emp.ToString());
                        }

                        break;



                    case 2:
                        Console.WriteLine("Enter Employee Number:");
                        int EmpNum = int.Parse(Console.ReadLine());
                        Console.WriteLine(EmpNum);

                        foreach (Employee emp in EmployeeList)
                        {

                            if (emp.EmpNo == EmpNum)
                            {
                                Console.WriteLine("Employee  Exists in the List");
                                Console.WriteLine(emp.ToString());
                                temp++;
                                break;

                            }
                           


                        }
                        if (temp == 0)
                        {
                            Console.WriteLine("Employee Not Found !!");
                        }
                      


                        break;

                }
                Console.WriteLine("do you wnat to continue? 'y' or 'n'");
                choice = Console.ReadLine();

            } while (choice == "y");
           
            Console.ReadLine();

        }



    }
}
