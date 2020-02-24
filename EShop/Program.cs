using EShop.DatabaseContext;
using EShop.EFModels;
using System;

namespace EShop
{
     class Program
    {
     static void Main(string[] args)
        {

            EShopDbContext db = new EShopDbContext();

            foreach(var product in db.Products)
            {
                Console.WriteLine($"Name: {product.Name} Price: {product.Price} WH Location: {product.WarehouseLocation}");
            }


            //Product prod = new Product()
            //{
            //    Name = "Dell Desktop",
            //    Code = " Dsk/001",
            //    Price = 35000
            //};

            //EShopDbContext db = new EShopDbContext();
            //db.Products.Add(prod);

            //int count = db.SaveChanges();

            //if (count > 0)
            //{
            //    Console.WriteLine("Success");
            //}
            //else
            //{
            //    Console.WriteLine("Failde");
            //}

            Console.ReadKey();
                                 

        }
    }
}
