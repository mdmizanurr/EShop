using EShop.Contracts;
using EShop.DatabaseContext;
using EShop.EFModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EShop.Repositories
{
     public class ProductRepository
    {
        private readonly EShopDbContext _db;

        public ProductRepository()
        {
            _db = new EShopDbContext();
        }


        public bool Add(Product product)
        {
            _db.Products.Add(product);
            return _db.SaveChanges() > 0;
        }

        public bool Update(Product product)
        {
            _db.Entry(product).State = EntityState.Modified;
            return _db.SaveChanges() > 0 ;
        }

        public bool Remove(Product product)
        {
            if (product is IDeleteable)
            {
                IDeleteable item = (IDeleteable)product;
                item.IsDeleted = true;
                return Update(product);
            }
            else
            {
                _db.Products.Remove(product);
                return _db.SaveChanges() > 0;
    
            }


        }

        public Product GetById(int id)
        {
            return _db.Products.Find(id);
        }

        public ICollection<Product> GetAll()
        {
            return _db.Products.ToList();
        }



    }
}
