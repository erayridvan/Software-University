using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            double result = DateModifier.GetDifferenceInDaysBetweenTwoDates(firstDate, secondDate);

            Console.WriteLine(result);
        }
    }
}
