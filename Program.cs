using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = new Random().Next(1, 101);

            for (int i = 4; i > 0; i--)
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
