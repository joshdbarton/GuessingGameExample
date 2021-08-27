using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 42;

            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Guess the secret number!");
                Console.Write($"Your Guess ({i}): ");
                var input = int.Parse(Console.ReadLine());

                if (secretNumber == input)
                {
                    Console.WriteLine("correct!");
                    break;
                }
                else
                {
                    Console.WriteLine("wrong");
                };
            }
        }
    }
}
