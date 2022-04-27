using AspNetMVC.LabExercise1.Models;
using System.Collections.Generic;

namespace AspNetMVC.LabExercise1.Services
{
    public class ProductService
    {
        private List<Product> products;

        public ProductService() //constructor
        {
            products = new List<Product>(); //instance of Product

            products.Add(new Product()
            {
                Id = 1,
                Name = "Powerhouse Chipping Hammer",
                Description = "Powerhouse Chipping Hammer 300 grams- 500 grams",
                Quantity = 1,
                Price = 1_000M
            });

            products.Add(new Product()
            {
                Id = 2,
                Name = "Lotion",
                Description = "Protects skin from harmful UV rays.",
                Quantity = 2,
                Price = 2_000M
            });

            products.Add(new Product()
            {
                Id = 3,
                Name = "Pencil",
                Description = "A writing utensil with a graphite lead embedded in a wooden shaft",
                Quantity = 5,
                Price = 3_000M
            });

            products.Add(new Product()
            {
                Id = 4,
                Name = "Electric Fan",
                Description = "8″ blade 3-speed rotary switch control Adjustable head for directing airflow",
                Quantity = 10,
                Price = 4_000M
            });

            products.Add(new Product()
            {
                Id = 5,
                Name = "Baby Spoon",
                Description = "Baby Spoons are small-sized spoons. This type of spoon is larger than the Coffee Spoon and Tea Spoon and is designed for use at breakfast time like for yoghurt.",
                Quantity = 7,
                Price = 5_000M,
            });

            products.Add(new Product()
            {
                Id = 6,
                Name = "American Crew Fiber - 3 oz",
                Description = "Fibre-like, resinous product helps thicken, texturize, and increase fullness to hair. Provides a strong, pliable hold with a matte finish. Works well in shorter hair.",
                Quantity = 5,
                Price = 2_000M
            });
        }



        public List<Product> GetCatalog()
        {
            return products;
        }

        public decimal GetGrandTotal()
        {
            decimal grandtotal = 0;
            foreach (var product in products)
            {
                grandtotal += (product.Price * product.Quantity);
            }
            return grandtotal;
        }

    }
}
