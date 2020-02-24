using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EShop.EFModels
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [StringLength(11)]
        public string Code { get; set; }
        public double Price { get; set; }
        public string WarehouseLocation { get; set; }



    }
}
