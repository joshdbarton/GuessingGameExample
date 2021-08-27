using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 42;

            Console.WriteLine("Guess the secret number!");
            Console.Write("Your Guess: ");

            try
            {
                var input = int.Parse(Console.ReadLine());
                if (secretNumber == input)
                {
                    Console.WriteLine("correct!");
                }
                else
                {
                    Console.WriteLine("wrong");
                };
            }
            catch
            {
                Console.WriteLine("Integers only please!");

            }

        }
    }
}
