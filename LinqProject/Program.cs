﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1, CategoryName ="Bilgisayar"},
                new Category{CategoryId=2, CategoryName ="Telefon"},
            };

            List<Product> products = new List<Product> {

            new Product{ProductId=1, CategoryId=1, ProductName = "Acer Laptop", QuantityPerUnit  ="32 GB Ram", UnitPrice = 18000, UnitsInStock= 5  },
            new Product{ProductId=2, CategoryId=1, ProductName = "Asus Laptop", QuantityPerUnit  ="16 GB Ram", UnitPrice = 18000, UnitsInStock= 3  },
            new Product{ProductId=3, CategoryId=1, ProductName = "Msi Laptop", QuantityPerUnit  ="4 GB Ram", UnitPrice = 5777, UnitsInStock= 2  },
            new Product{ProductId=4, CategoryId=2, ProductName = "Samsung Telefon", QuantityPerUnit  ="4 GB Ram", UnitPrice = 1323, UnitsInStock= 15  },
            new Product{ProductId=5, CategoryId=2, ProductName = "Apple Telefon", QuantityPerUnit  ="8 GB Ram", UnitPrice = 4000, UnitsInStock= 0  },


            };


            // Test(products);

            // GetProducts(products);

            // AnyTest(products);

            // FindTest(products);

            //FindAllTest(products);

            // AscDscTest(products);

            var result = from p in products
                         where p.UnitsInStock > 6000
                         orderby p.UnitPrice descending, p.ProductName ascending
                         select p;
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }

        }

        private static void AscDscTest(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice).ThenByDescending(p => p.ProductName);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindAllTest(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("cer"));
            Console.WriteLine(result);
        }

        private static void FindTest(List<Product> products)
        {
            var result = products.Find(p => p.ProductId == 3);
            Console.WriteLine(result.ProductName);
        }

        private static void AnyTest(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == "Acer");
            Console.WriteLine(result);
        }

        private static void Test(List<Product> products)
        {
            Console.WriteLine("Algoritmik-----------");

            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                {
                    Console.WriteLine(product.ProductName);

                }
            }

            Console.WriteLine("Linq-----------");

            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();


            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                {
                    filteredProducts.Add(product);
                }
            }
            return filteredProducts;
        }
        static List<Product> GetProductsLinq(List<Product> products)
        {
           return products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3).ToList();
        }


    }
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }

}








































































































































































































































































































































































































































