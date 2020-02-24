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

            //Product Create

            var p1 = new Product()
            {
                Name = "Table",
                Code = "T001",
                Price = 10000,
                WarehouseLocation = "Dhaka"
            };

            var p2 = new Product()
            {
                Name = "Chair",
                Code = "C001",
                Price = 5000,
                WarehouseLocation = "Dhaka"
            };


            //Shop Add

            var shop = new Shop()
            {
                Name = "Kawran Bazar Shop"
            };

            shop.Products.Add(p1);
            shop.Products.Add(p2);

            db.Shops.Add(shop);

            int successCount = db.SaveChanges();

            if (successCount > 0)
            {
                Console.WriteLine("Shop Added");
            }
            else
            {
                Console.WriteLine("Failed");
            }






            foreach (var product in db.Products)
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
