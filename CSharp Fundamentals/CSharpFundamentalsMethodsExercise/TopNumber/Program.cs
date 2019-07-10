using System;

namespace TopNumber
{
    class Program
    {
        static void Main()
        {
            int index = int.Parse(Console.ReadLine());
            TopNumberFinder(index);
        }

        static void TopNumberFinder(int index)
        {

            for (int i = 0; i < index; i++)
            {
                int currentNumber = i;
                int sum = 0;

                while (currentNumber>0)
                {
                    int currentDigit = currentNumber % 10;
                    sum += currentDigit;
                    currentNumber /= 10;
                }

                if (sum%8==0)
                {
                    int currNumber = i;

                    while (currNumber>0)
                    {
                        int currentDigit =  currNumber % 10;

                        if (currentDigit % 2 != 0)
                        {
                            Console.WriteLine(i);
                            break;
                        }
                        currNumber /= 10;
                    }
                }
            }
        }
    }
}
