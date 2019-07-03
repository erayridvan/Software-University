using System;

namespace SeriesCalculator
{
    class Program
    {
        static void Main()
        {
            string nameOfSeries = Console.ReadLine();
            int numberOfSeasons = int.Parse(Console.ReadLine());
            int numberOfEpisodes = int.Parse(Console.ReadLine());
            double timeForOneEpisode = double.Parse(Console.ReadLine());

            double advertiseTime = 0.20 * timeForOneEpisode;
            double totalTimeForOneEpisode = advertiseTime + timeForOneEpisode;
            int specialEpisodeTime = numberOfSeasons * 10;
            double totalMinutesToWatch = totalTimeForOneEpisode * numberOfEpisodes * numberOfSeasons + specialEpisodeTime;

            Console.WriteLine($"Total time needed to watch the {nameOfSeries} series is {totalMinutesToWatch} minutes.");
        }
    }
}
