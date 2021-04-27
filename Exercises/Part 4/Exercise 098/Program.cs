using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_98
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            Product product = new Product("Banana", 1.1, 13);
            product.PrintProduct();
        }
    }

    class Product
    {
        public string name;
        public double price;
        public int quantity;

        public Product(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public void PrintProduct()
        {
            Console.WriteLine(name + " Price: " + price + " Quantity: " + quantity + "pcs");
        }
    }
}



