using System;
using System.Collections;
using System.Collections.Generic;

namespace CyberSpace
{
    public class Program
    {
        static void Main()
        {
            List<Product> products = new List<Product>()
            {
                new Product{ Name = "Butter", Quantity = 4 },
                new Product{ Name = "Cornflakes", Quantity = 56},
                new Product{ Name = "burger", Quantity = 35},
                new Product {Name = "Bread", Quantity = 20},
                new Product{ Name = "Milk", Quantity = 13},
                new Product{ Name = "sardine", Quantity = 10},
                new Product{ Name = "wafers Biscuit", Quantity = 20},
                new Product{Name = "GoldenMorn", Quantity = 7 },
                new Product{ Name = "Doughnut", Quantity = 15},
                new Product{Name = "Sugar", Quantity = 25 }

            };
            products.Sort(new Comparer());
            foreach(Product p in products)
                Console.WriteLine(p);
        }
    }
    public class Comparer : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            if(x.Quantity > y.Quantity)
            {
                return 1;
            }
            else if (x.Quantity < y.Quantity)
                return -1;
            else
                return 0;
        }
    }
    public class Product
    {
        public string Name { get; set; }    
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Quamtity: {Quantity}";
        }

    }

}


