using EShop.DatabaseContext;
using EShop.DTO;
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

            var searchCriteria = new ProductSearchCriteriaDTO()
            {
                Name = "Laptop",
                FromSalesPrice = 1000
            };

            var products = _unitofWork.ProductRepository.Search(searchCriteria);

            foreach (var product in products)
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
