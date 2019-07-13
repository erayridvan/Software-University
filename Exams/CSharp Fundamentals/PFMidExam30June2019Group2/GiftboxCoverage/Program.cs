using System;

namespace GiftboxCoverage
{
    class Program
    {
        static void Main()
        {
            double sizeOfSide = double.Parse(Console.ReadLine());
            int sheets = int.Parse(Console.ReadLine());
            double sheetArea = double.Parse(Console.ReadLine());


            double boxArea = sizeOfSide * sizeOfSide * 6;
            double totalSheetArea = sheets * sheetArea;

            int sheetsCoverLess = sheets / 3;
            int LeftSheets = sheets - sheetsCoverLess;

            double totalAreaSheetsCover = (LeftSheets * sheetArea) + (sheetsCoverLess*(0.25*sheetArea));
            double percentage = totalAreaSheetsCover * 100 / boxArea;

            Console.WriteLine("You can cover {0:f2}% of the box.",percentage);
        }
    }
}
