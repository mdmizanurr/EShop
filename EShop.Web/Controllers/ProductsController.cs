using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Web.Controllers
{
    public class ProductsController : Controller
    {

        public string List(string Name, string Code, double FromPrice)
        {
            return $"Hello {Name ?? "N/A"}  you are in product module  {Code ?? "N/A"}  and from price {FromPrice} ";
        }
    }
}
