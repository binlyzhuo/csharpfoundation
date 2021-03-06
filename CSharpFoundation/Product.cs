﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFoundation
{
    public class Product
    {
        private readonly string name;

        public string Name
        {
            get { return name; }
        }

        private readonly decimal price;

        public decimal Price
        {
            get { return price; }
        }

        public Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public override string ToString()
        {
            //return base.ToString();
            return string.Format("{0}:{1}",name,price);
        }

        public static List<Product> GetSampleProducts()
        {
            return new List<Product>
            {
                new Product(name:"west",price:10),
                new Product(name:"assassins",price:11),
                new Product(name:"frogs",price:12),
                new Product(name:"sweeney",price:13)
            };
        }

        public static void ExecuteCodes()
        {
            var products = GetSampleProducts();
            products.Sort(new ProductNameComparer());
            ProductNameComparer productNameComparer = new ProductNameComparer();
            //Comparison<int> comparison = new Comparison<int>(productNameComparer.Compare);
            //Comparison<int> comparer = new ProductNameComparer().Compare();
            products.Sort(delegate(Product x, Product y)
            {
                return x.Name.CompareTo(y.Name);
            });
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }
    }

    public class ProductNameComparer : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
