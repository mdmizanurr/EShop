using EShop.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.Repositories
{
    class UnitofWork
    {
        private EShopDbContext _db;

        public UnitofWork()
        {
            _db = new EShopDbContext();
        }


        private  ProductRepository _productRepository;
        private ShopRepository _shopRepository;

        public ProductRepository ProductRepository { 
            get
            {
                if(_productRepository == null)
                {
                    _productRepository = new ProductRepository(_db);
                }
                return _productRepository;
            } 
        }


        public ShopRepository ShopRepository
        {
            get
            {
                if(_shopRepository == null)
                {
                    _shopRepository = new ShopRepository(_db);
                }

                return _shopRepository;
            }
        }


        public bool SaveChanges()
        {
            return _db.SaveChanges() > 0 ;
        }













    }
}
