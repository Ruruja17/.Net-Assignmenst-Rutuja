using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLib
{
    public class Product
    {
        private string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }

        }

        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double GetProductcCost()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return String.Format($"ProductName : {ProductName} Quantity : {Quantity} Price: {price} Cost: {GetProductcCost()} ");
        }
    }
}
