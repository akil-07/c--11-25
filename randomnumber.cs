using System;

namespace RandomNumber
{
    class Program
    {
        static void Main()
        {
            int guess = 0;
            int max = 100;
            int min = 1;
            int number;
            int guesses = 0;
            string response;
            bool again = true;
            Random random = new Random();

            while (again)
            {
                Console.WriteLine("\n--- WELCOME TO RANDOM GUESS ---");
                guess = 0;
                guesses = 0;
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.Write("Enter the number = ");
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess > number)
                    {
                        Console.WriteLine("The given number is lower than your guess.");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine("The given number is higher than your guess.");
                    }

                    guesses++;
                }

                Console.WriteLine("\nYOU GUESSED IT CORRECTLY!");
                Console.WriteLine("The number was: " + number);
                Console.WriteLine("You took " + guesses + " guesses.");
                Console.Write("\nWould you like to play again? (Y/N): ");
                response = Console.ReadLine().ToUpper();
                again = (response == "Y");
            }

            Console.WriteLine("\nThanks for playing!");
        }
    }
}
