using System;
using ClassLibrary;

namespace EnumTryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            Console.WriteLine("Nece product olsun? ");
            int count = int.Parse(Console.ReadLine());

            Product[] products = new Product[count];

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Productin adini daxil edin: ");
                string str = Console.ReadLine();
                products[i].Name = str;

                Console.WriteLine("Productin qiymetini daxil edin: ");
                int price = int.Parse(Console.ReadLine());
                products[i].Price = price;

                Console.WriteLine("=======T Y P E S=======");
                foreach (var item in Enum.GetValues(typeof(ProductType)))
                {
                    Console.WriteLine((byte)item + " - " + item);
                }
                Console.WriteLine("Productin type ni daxil edin: ");
                string typeStr = Console.ReadLine();
                byte typeByte;

                while (!byte.TryParse(typeStr, out typeByte))
                {
                    Console.WriteLine("Eded daxil edin:");
                    typeStr = Console.ReadLine();
                }

                while (!Enum.IsDefined(typeof(ProductType), typeByte))
                {
                    Console.WriteLine("Dogru secim edin:");
                    typeStr = Console.ReadLine();
                    while (!byte.TryParse(typeStr, out typeByte))
                    {
                        Console.WriteLine("Eded daxil edin:");
                        typeStr = Console.ReadLine();
                    }
                    typeByte = Convert.ToByte(typeStr);
                }

                ProductType selectedtype = (ProductType)typeByte;
                products[i].Type = selectedtype;

                store.AddPrduct(products[i]);
            }

            store.FilterProductsByName("Alma");
            store.FilterProductsByType(ProductType.Drink);

            

            
            

            
           



        }
    }
}
