using System;
using System.Linq;
using System.Collections.Generic;

namespace ProductShop
{
    class Program
    {
        static void Main()
        {
            var infoAboutShops = new Dictionary<string,Dictionary<string,double>>();

            while (true)
            {
                string args = Console.ReadLine();
                if (args== "Revision")
                {
                    break;
                }

                string[] info = args.Split(", ");
                string shopName = info[0];
                string product = info[1];
                double price = double.Parse(info[2]);

                if (!infoAboutShops.ContainsKey(shopName))
                {
                    infoAboutShops[shopName] = new Dictionary<string, double>();
                }
                infoAboutShops[shopName][product] = price;
            }

            foreach (var shop in infoAboutShops.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var info in shop.Value)
                {
                    Console.WriteLine($"Product: {info.Key}, Price: {info.Value}");
                }
            }
        }
    }
}
