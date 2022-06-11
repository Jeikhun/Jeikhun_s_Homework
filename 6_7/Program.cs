using System;

namespace DolphinKitab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop delfinkitab = new Shop();
            ChoseFromMenu(delfinkitab);
        }

        public static void ChoseFromMenu(Shop shop)
        {
            Main:
            Console.WriteLine("1.Mehsul elave edin.");
            Console.WriteLine("2.Mehsul satin.");
            Console.WriteLine("3.Mehsullara baxin");
            Console.WriteLine("4.Budce");
            string choose = Console.ReadLine();
            switch (choose)
            {
                case "1":
                    AddProduct(shop);
                    break;
                case "2":
                    SellProduct(shop);
                    break;
                case "3":
                    shop.ViewProduct(shop);
                    ChoseFromMenu(shop);
                    break;
                case "4":
                    shop.Budget(shop);
                    ChoseFromMenu(shop);
                    break;


            }
            static void AddProduct(Shop shop)
            {
                Product product;
                Console.WriteLine("Mehsulun novunu daxil edin:   Aze or Turk");
            Type:
                string typestr = Console.ReadLine();
                if (typestr.ToUpper() == "AZE")
                {
                    product = new AzBook();

                }
                else if(typestr.ToUpper() == "TURK")
                {
                    product=new TrBook();
                }
                else
                {
                    Console.WriteLine("Zehmet olmazsa duzgun daxil edin");
                    goto Type;
                }
                Console.WriteLine("Mehsulun adini daxil edin");
                price:
                product.Name= Console.ReadLine();
                Console.WriteLine("Mehsulun qiymetini daxil edin:");
                string pricestr = Console.ReadLine();
                bool priceb = double.TryParse(pricestr, out double num);
                if (!priceb)
                {
                    Console.WriteLine("Zehmet olmazsa qiymeti duzgun daxil edin.");
                    goto price;
                }product.Price = num;
                Console.WriteLine("Sayini daxil edin:");
                Count:
                string countstr = Console.ReadLine();
                bool countb = int.TryParse(countstr, out int num1);
                if (!countb)
                {
                    Console.WriteLine("Zehmet olmazsa duzgun daxil edin");
                    goto Count;
                }product.Count = num1;
                shop.Add(product);
                ChoseFromMenu(shop);
            }
            static void SellProduct(Shop shop)
            {
                Console.WriteLine("Ne isteyirsiniz?");
                string name = Console.ReadLine();
                Console.WriteLine("Nece eded isteyirsiniz?");
                count:
                string countstr = Console.ReadLine();
                bool countb = int.TryParse(countstr, out int num);
                if (!countb)
                {
                    Console.Write("Zehmet olmazsa duzgun daxil edin:");
                    goto count;
                }
                shop.Sell(name, num);
                ChoseFromMenu(shop);
            }



        }
    }
}
