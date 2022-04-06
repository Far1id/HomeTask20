using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Product
    {
        public Product()
        {
            TotalCount++;
            No = TotalCount;
        }
        public static int TotalCount;
        public int No { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public ProductType Type { get; set; }
    }
}
