namespace ClimbThePeaks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> food = new Stack<int>
                (Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray());

            Queue<int> stamina = new Queue<int>
                (Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray());

            Dictionary<string, int> peaksInfo =new Dictionary<string, int>()
            {
                { "Vihren",80 },
                { "Kutelo",90 },
                { "Banski Suhodol",100 },
                { "Polezhan",60 },
                { "Kamenitza",70 }
            };

            bool isClimbed = false;

            for (int i = 0; i < length; i++)
            {

            }
    }
}
}