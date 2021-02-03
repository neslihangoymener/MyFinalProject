using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID (O : Open Closed Principle : yeni bir özellik eklediğinde mevcuttaki kodlara dokunamazsın)
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetByUnitPrice(40,100))
            {
                Console.WriteLine("Ürün Adı: "+product.ProductName);
            }

            Console.ReadLine();    
        }
    }
}
