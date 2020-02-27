using EShop.DatabaseContext;
using EShop.EFModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EShop.Repositories
{
   public class ShopRepository
    {
        private readonly EShopDbContext _db;

        public ShopRepository(EShopDbContext db)
        {
            _db = db;
        }


        public Shop GetById(int id)
        {
            return _db.Shops.Find(id);
        }


        public void Add(Shop shop)
        {
            _db.Shops.Add(shop);
        }


        public ICollection<Shop> GetAll()
        {
            return _db.Shops.ToList();
        }

        public void LoadProducts(Shop shop)
        {
            _db.Entry(shop)
                .Collection(c => c.Products)
                .Load();
        }

        public void Update(Shop shop)
        {
            _db.Entry(shop).State = EntityState.Modified; 
        }




    }
}
