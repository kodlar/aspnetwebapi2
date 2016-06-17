﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApplicationAPI.Models;

namespace WebApplicationAPI.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
                             {
                                 new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
                                 new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
                                 new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
                             };

        public IEnumerable<Product> GetAllProducts()
        {
            return this.products;
        }


        public IHttpActionResult GetProduct(int id)
        {
            var product = this.products.FirstOrDefault(z => z.Id == id);
            if (product == null)
            {
                return this.NotFound();
            }

            return this.Ok(product);
        }
    }
}
