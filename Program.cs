using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("difficulty level? 1 -easy, 2 - medium, 3 -hard");
            var difficulty = int.Parse(Console.ReadLine());

            int secretNumber = new Random().Next(1, 101);

            //represents number of tries by difficult level
            var difficultiesTries = new int[] { 8, 6, 4 };

            for (int i = difficultiesTries[difficulty - 1]; i > 0; i--)
            {
                Console.WriteLine("Guess the secret number!");
                Console.Write($"Your Guess (Guesses Left: {i}): ");
                var input = int.Parse(Console.ReadLine());

                if (secretNumber == input)
                {
                    Console.WriteLine("correct!");
                    break;
                }
                else if (secretNumber > input)
                {
                    Console.WriteLine("Too low!");
                }
                else
                {
                    Console.WriteLine("too High!");
                };
            }
        }
    }
}
