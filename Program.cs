using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("difficulty level? 1 -easy, 2 - medium, 3 -hard, 4 - cheater");
            var difficulty = int.Parse(Console.ReadLine());
            int i = new int[] { 8, 6, 4, 1}[difficulty - 1];

            int secretNumber = new Random().Next(1, 101);
            
            while (difficulty == 4 || i > 0)
            {
                string guessesLeft = difficulty == 4 ? "INFINITE!" : i.ToString();
                Console.WriteLine("Guess the secret number!");
                Console.Write($"Your Guess (Guesses Left: {guessesLeft}): ");
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
                i--;
            }
           
        }
    }
}
