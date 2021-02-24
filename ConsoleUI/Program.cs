﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle
    class Program
    {
        static void Main(string[] args)
        {
            //Data Transformation Object
            ProductTest();
            //IoC 
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            var result = categoryManager.GetAll();
            if (result.Success == true)
            {
                foreach (var category in result.Data)
                {
                    Console.WriteLine(category.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));

            var result = productManager.GetProductDetails(); 
                if (result.Success == true)
                {
                    foreach (var product in result.Data)
                    {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                    }
                }
                else
                {
                Console.WriteLine(result.Message);
                }
                
                
            
        }
    }
}