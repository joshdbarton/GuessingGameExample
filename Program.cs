using System;
using System.Collections.Generic;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("difficulty level? 1 -easy, 2 - medium, 3 -hard, 4 -hardest");
            var difficulty = int.Parse(Console.ReadLine());

            int secretNumber = new Random().Next(1, 101);

            //represents number of tries by difficult level
            List<int> difficultiesTries = new List<int>
             { 
                 8, 
                 6, 
                 4, 
                 2 
             };

            int numOfTries = difficultiesTries[difficulty - 1];

            for (int i = numOfTries; i > 0; i--)
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
