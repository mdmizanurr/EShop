using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.EFModels
{
    public class Shop
    {

        public Shop()
        {
            Products = new List<Product>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }

    }
}
