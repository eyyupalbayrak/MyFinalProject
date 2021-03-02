using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //hatan şu 2 hata var birincisi bu iproductdal 2 yerde var biri data accesste diğeri
            //businesste normalde sonu dal olanlar dataaccess projesinde olur birinci hata bu 
            // 2 hata internal yapmışsın internal sadece o proje için geçerli 
            //yani business içinde bir internal tanımlamışsan onu consoleui içinde kullanamazsın
            






            ProductManeger productManeger = new ProductManeger(new EfProductDal());

            foreach (var product in productManeger.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }





            Console.WriteLine("Hello World!");
        }
    }

    
}
