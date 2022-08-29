using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    internal class BubbleSort
    {
       
           static void Main(string[] args)
        {
            Console.WriteLine(" Bubble Sort ");

            int[] Num = { 54, 45, 90, 22, 17, 71,8,12 };
            int temp;

            for (int i = 0; i < Num.Length; i++)
            
            {
                for (int j = 0; j < Num.Length - 1 - i; j++)
                { 
                    if (Num[j] > Num[j + 1]) 
                    { 
                        temp = Num[j]; Num[j] = Num[j + 1];
                        Num[j + 1] = temp; 
                    }
                } }

            foreach (int a in Num) { Console.Write(a + " "); }

            Console.ReadLine();

        }


        
    }
}