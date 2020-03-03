using EShop.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EShop.EFModels
{
    public class Product : IDeleteable
    {
        public Product()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }

        [StringLength(11)]
        public string Code { get; set; }
        public double Price { get; set; }
        public string WarehouseLocation { get; set; }

        public int? DokanId { get; set; }
        public Shop Dokan { get; set; }
        public bool IsDeleted { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public string DeleteRemarks { get; set; }
    }
}
