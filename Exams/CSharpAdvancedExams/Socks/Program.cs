using System;
using System.Collections;
using System.Linq;

namespace Socks
{
    class Program
    {
        static void Main()
        {
            int[] lSocks = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            Stack leftSocks = new Stack();

            for (int i = 0; i < lSocks.Length; i++)
            {
                int currentSock = lSocks[i];
                leftSocks.Push(currentSock);
            }

            int[] rSocks = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            Queue rightSocks = new Queue();
           
            for (int i = 0; i < rSocks.Length; i++)
            {
                int currentSock = rSocks[i];
                rightSocks.Enqueue(currentSock);
            }

            PairMaker(leftSocks, rightSocks);
            // TODO: правилно ли съм използвал метода 
            // TODO: качествен ли е кодът..ако не? какво мога да подобря
             
        }

        private static void PairMaker(Stack leftSocks, Queue rightSocks)
        {
            Queue pairedSocks = new Queue();

            int index = Math.Max(leftSocks.Count, rightSocks.Count);

            for (int i = 0; i < index; i++)
            {
                if (leftSocks.Count <= 0)
                {
                    break;
                }

                if (rightSocks.Count <= 0)
                {
                    break;
                }

                int leftCurrentSock = (int)leftSocks.Peek();
                int rightCurrentSock = (int)rightSocks.Peek();

                if (leftCurrentSock > rightCurrentSock)
                {
                    int pair = leftCurrentSock + rightCurrentSock;
                    pairedSocks.Enqueue(pair);
                    leftSocks.Pop();
                    rightSocks.Dequeue();
                }
                else if (leftCurrentSock < rightCurrentSock)
                {
                    leftSocks.Pop();
                }
                else if (leftCurrentSock == rightCurrentSock)
                {
                    rightSocks.Dequeue();
                    leftCurrentSock++;
                    leftSocks.Pop();
                    leftSocks.Push(leftCurrentSock);
                }
            }

            var result = pairedSocks.ToArray();

            Console.WriteLine(result.Max());

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
