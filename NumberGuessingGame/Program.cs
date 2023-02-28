using System;
namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main()
        {
            const int MIN_NUMBER = 1;
            const int MAX_NUMBER = 10;
            const int NUMBER_OF_GUESSES = 3;
            int targetNumber = new Random().Next(MIN_NUMBER, MAX_NUMBER + 1);

            Console.WriteLine($"Guess a number between {MIN_NUMBER} and {MAX_NUMBER}. You have {NUMBER_OF_GUESSES} guesses.");

            for (int i = 0; i < NUMBER_OF_GUESSES; i++)
            {
                int guess;
                bool isValidGuess;
                do
                {
                    Console.Write($"Guess #{i + 1}: ");
                    isValidGuess = int.TryParse(Console.ReadLine(), out guess);

                    if (!isValidGuess || guess < MIN_NUMBER || guess > MAX_NUMBER)
                        Console.WriteLine($"Invalid input ,Please enter a number between {MIN_NUMBER} and {MAX_NUMBER}.");

                } while (!isValidGuess || guess < MIN_NUMBER || guess > MAX_NUMBER);

                if (guess == targetNumber)
                {
                    Console.WriteLine("Perfect, you guessed the correct number!");
                    break;
                }
                if (i == NUMBER_OF_GUESSES - 1)
                    Console.WriteLine($"Sorry, you failed to guess the number. The correct number was {targetNumber}.");
                else

                    Console.WriteLine("Sorry, that was not the correct number. Please try again.");
            }

        }
    }
}
