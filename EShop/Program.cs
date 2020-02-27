using EShop.DatabaseContext;
using EShop.EFModels;
using EShop.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EShop
{
     class Program
    {
     static void Main(string[] args)
        {
            UnitofWork _unitofWork = new UnitofWork();


            foreach (var shop in _unitofWork.ShopRepository.GetAll())
            {
                _unitofWork.ShopRepository.LoadProducts(shop);

                Console.WriteLine("Shop Info..................");
                Console.WriteLine($" Shop Name: {shop.Name} ");
                                                     

                if( shop.Products.Any())
                {
                    Console.WriteLine("\t\t Product Info");
                    foreach (var shopProduct in shop.Products)
                    {
                        Console.WriteLine("\t\t "+GetProductInfo(shopProduct));
                    }

                }
                else
                {
                    Console.WriteLine("No Products found");
                }
            }

            Console.WriteLine();

            foreach (var product in _unitofWork.ProductRepository.GetAll())
            {
                Console.WriteLine(GetProductInfo(product));

            }

        }
        
        static string GetProductInfo(Product product)

        {
            return $"Name: {product.Name} Price: {product.Price} WH Location: {product.WarehouseLocation} Shop Id: {product.Dokan?.Id.ToString() ?? "N/A"} Shop name: {product.Dokan?.Name ?? "N/A "}";
        }


    }
}
