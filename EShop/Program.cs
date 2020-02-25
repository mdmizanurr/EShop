using EShop.DatabaseContext;
using EShop.EFModels;
using EShop.Repositories;
using Microsoft.EntityFrameworkCore;
using System;

namespace EShop
{
     class Program
    {
     static void Main(string[] args)
        {
            ProductRepository _repo = new ProductRepository();

            var existingProduct = new Product() 
            { 
                Id = 14,
                Name = "Wheel Chair",
                Code = "WC001",
                Price = 20000

            };

            bool isUpdated = _repo.Update(existingProduct);

            if (isUpdated)
            {
                Console.WriteLine("Product Updated");
            }


            foreach (var product in _repo.GetAll())
            {
                Console.WriteLine($"Name: {product.Name} Price: {product.Price} WH Location: {product.WarehouseLocation} Shop Name: {product.DokanId}");
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
