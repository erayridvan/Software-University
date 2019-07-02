using System;
using System.Collections.Generic;
using System.Linq;

namespace EasterGifts
{
    class Program
    {
        static void Main()
        {
            List<string> gifts = Console.ReadLine()
                .Split(" ")
                .ToList();

            while (true)
            {
                string text = Console.ReadLine();

                if (text == "No Money")
                {
                    break;
                }

                List<string> currentGift = text
                    .Split(" ")
                    .ToList();

                string command = currentGift[0];
                string gift = currentGift[1];

                if (command == "OutOfStock")
                {
                    for (int i = 0; i < gifts.Count; i++)
                    {
                        if (gifts[i].Contains(gift))
                        {
                            gifts[i] = "None";
                        }
                    }
                }
                else if (command == "Required")
                {
                    int index = int.Parse(currentGift[2]);

                    if (index < gifts.Count && index>=0)
                    {
                        gifts[index] = gift;
                    }
                }
                else if (command == "JustInCase")
                {
                    gifts[gifts.Count - 1] = gift;
                }
            }

            foreach (var item in gifts)
            {
                if (item != "None")
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
