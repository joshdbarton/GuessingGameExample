using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the secret number!");
            Console.Write("Your Guess: ");
            var input = Console.ReadLine();
            Console.WriteLine($"You guessed: {input}");
        }
    }
}
