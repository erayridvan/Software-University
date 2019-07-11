using System;

namespace DataTypes
{
    class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();
            DataTypeChecker(type);
        }

        static void DataTypeChecker(string type)
        {
            if (type=="int")
            {
                int number = int.Parse(Console.ReadLine());
                int result = 2 * number;
                Console.WriteLine(result);
            }
            else if (type=="real")
            {
                double number = double.Parse(Console.ReadLine());
                double result = number * 1.5;
                Console.WriteLine($"{result:f2}");
            }
            else if (type=="string")
            {
                string word = Console.ReadLine();
                Console.WriteLine($"${word}$");
            }
        }
    }
}
