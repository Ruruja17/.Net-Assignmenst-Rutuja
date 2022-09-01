using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    public class Swap
    {
        private int num1 = 10;

        public int Display()
        {
            return num1;
        }
        
    }

    public class Swap2
    {

        private int num3 = 20;

        public int Display1()
        {
            return num3;
        }
        static void Main(string[] args)
        {
            Swap s = new Swap();
            int num2 = s.Display();
            Swap2 s1 = new Swap2();
            int num4 = s1.Display1();
            
            

            Console.WriteLine("before swapping:"  +num2);
            Console.WriteLine("before swapping:"  + num4);
            
            SwapNum(  ref num2,  ref num4);

            Console.WriteLine("After Swaping:"+ num2);
            Console.WriteLine("After Swaping:" + num4);



            Console.ReadLine();
        }

        static void SwapNum(ref int num2,  ref int num4)
        {
            int temp;
            temp = num2;
            num2 = num4;
            num4 = temp;

            

        }


       
    }
    
    
}
