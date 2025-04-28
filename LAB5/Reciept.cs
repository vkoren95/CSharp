using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Immutable;



namespace VubCaffe
{
    public class Reciept
    {
        public Reciept()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public ImmutableList<Product> Products
        {
            get => products.ToImmutableList();
        }
        public double Total()
        {
            double total = 0;
            foreach (var product in products)
            {
                total += product.Totalprice();
            }
            return total;
        }
        private List<Product> products;

    }

}
