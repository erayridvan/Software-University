using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ParkingLot
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var parking = new HashSet<string>();

            while (input!="END")
            {
                var inpurParams = Regex.Split(input, ", ");

                if (inpurParams[0]=="IN")
                {
                    parking.Add(inpurParams[1]);
                }
                else
                {
                    parking.Remove(inpurParams[1]);
                }
                input = Console.ReadLine();
            }
            if (parking.Count!=0)
            {
                foreach (var number in parking)
                {
                    Console.WriteLine(number);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }

    }
}
