using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Shop
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void DisplayProductsWithDiscount(decimal discountPercentage)
        {
            Console.WriteLine("Продукты со скидкой:");
            foreach (var product in products)
            {
                decimal discountedPrice = product.Price * (1 - discountPercentage / 100);
                Console.WriteLine($"{product.GetInformation()}, Цена с учетом скидки: {discountedPrice:C}");
            }
        }
    }
}
