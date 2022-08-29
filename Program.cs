using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingLib;

namespace TestShopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
           
            
            product.ProductName = "JOHNSON";
            product.Price = 200;
            product.Quantity = 23;

            Console.WriteLine(product);

            Product product1 = new Product();


            product1.ProductName = "Noodles";
            product1.Price = 12;
            product1.Quantity = 50;

            Console.WriteLine(product1);

            product1.ProductName = "Nivya";
            product1.Price = 123;
            product1.Quantity = 15;

            Console.WriteLine(product1);




            Console.ReadLine();

        }
    }
}
