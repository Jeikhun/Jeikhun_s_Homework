using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolphinKitab
{

    internal class Shop
    {
        public double TotalIncome { get; set; }

        Product[] products = new Product[0];
        public void Add(Product product)
        {
            foreach (var item in products)
            {
                if(product.Name == item.Name)
                {
                    item.Count += product.Count;
                    return;
                }
            }
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;
        }
        public void Sell(string sellName, int count)
        {
            int say = 0;
            foreach (var item in products)
            {
                if (sellName == item.Name)
                {
                    if (item.Count >= count)
                    {
                        item.Count -= count;
                        TotalIncome = item.Price * count;
                        say = item.Count;
                    }
                    else
                    {
                        Console.WriteLine("Stokda bu kitabdan yalniz " +item.Count + " eded var");
                    }
                }
                else
                {
                    Console.WriteLine("Stokda bele bir mehsul tapilmadi");
                    return;
                }
            }
            Console.WriteLine(count + " eded " + sellName + " satildi");
            Console.WriteLine(say + " eded " + sellName + " qaldi");

        }
        public void ViewProduct(Shop shop)
        {
            foreach(var item in products)
            {
                Console.WriteLine("Mehsulun adi " + item.Name);
                Console.Write("qiymeti: " + item.Price);
                Console.WriteLine("Stokdaki sayi: " + item.Count);
            }
        }
        public void Budget(Shop shop)
        {
            Console.WriteLine(TotalIncome);
        }
    }

    class Product
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
    }

    class TrBook:Product
    {

    }

    class AzBook:Product
    {

    }
}
