using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3_Models.Models
{
    public class ProductRepository
    {
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product
            {
                ID = 1,
                Name = "A Ürünü",
                Stok = 20,
                Price = 500.19m
            });

            products.Add(new Product
            {
                ID =2,
                Name = "B Ürünü",
                Stok = 30,
                Price = 999.99m
            });


            products.Add(new Product
            {
                ID = 3,
                Name = "C Ürünü",
                Stok = 2000,
                Price = 99.99m
            });

            products.Add(new Product
            {
                ID = 4,
                Name = "D Ürünü",
                Stok = 20000,
                Price = 9.99m
            });
            return products;
        }
    }
}