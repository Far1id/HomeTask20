using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Store
    {
        public Product[] Products = new Product[0];

        public void AddPrduct(Product product)
        {
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = product;
        }
        public Product[] RemoveProductByNo(int no)
        {
            Product[] NewProducts = new Product[Products.Length - 1];

            int i = 0;
            foreach (var item in Products)
            {
                if (item.No != no)
                {
                    NewProducts[i] = item;
                }
            }

            foreach (var item in NewProducts)
            {
                Console.WriteLine(item.No + item.Name + item.Price + item.Type);
            }

            return NewProducts;
        }
        public Product[] FilterProductsByType(ProductType type)
        {
            Product[] FilteredProducts = new Product[0];

            foreach (var item in Products)
            {
                if (item.Type == type)
                {
                    Array.Resize(ref FilteredProducts, FilteredProducts.Length + 1);
                    FilteredProducts[FilteredProducts.Length - 1] = item;
                }
            }

            foreach (var item in FilteredProducts)
            {
                Console.WriteLine(item.No + item.Name + item.Price + item.Type);
            }

            return FilteredProducts;
        }
        public Product[] FilterProductsByName(string name)
        {
            Product[] FilteredProducts2 = new Product[0];

            foreach (var item in Products)
            {
                if (item.Name == name)
                {
                    Array.Resize(ref FilteredProducts2, FilteredProducts2.Length + 1);
                    FilteredProducts2[FilteredProducts2.Length - 1] = item;
                }
            }

            foreach (var item in FilteredProducts2)
            {
                Console.WriteLine(item.No + item.Name + item.Price + item.Type);
            }

            return FilteredProducts2;
        }

    }
}
