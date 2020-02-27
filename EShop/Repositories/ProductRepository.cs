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

        public ProductRepository(EShopDbContext db)
        {
            _db = db;
        }


        public void Add(Product product)
        {
            _db.Products.Add(product);
           // return _db.SaveChanges() > 0;
        }

        public void Update(Product product)
        {
            _db.Entry(product).State = EntityState.Modified;
          //  return _db.SaveChanges() > 0 ;
        }

        public void Remove(Product product)
        {
            if (product is IDeleteable)
            {
                IDeleteable item = (IDeleteable)product;
                item.IsDeleted = true;
                Update(product);
            }
            else
            {
                _db.Products.Remove(product);
                   
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
