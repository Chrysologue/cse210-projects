using System;

class Program
{
    static void Main(string[] args)
    {   
        bool isPlayAgain = true;
        string playAgain;

        while (isPlayAgain)
        {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int guess = 0;
        int guessCount = 0;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = Convert.ToInt32(Console.ReadLine());
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            guessCount += 1;

        }Console.WriteLine("You guessed it!");
        Console.WriteLine($"It took you {guessCount} guesses");
        Console.Write("Would you like to play again? ");
        playAgain = Console.ReadLine().ToLower();
        if (playAgain == "yes")
        {
            isPlayAgain = true;
        }
        else
        {
            isPlayAgain = false;
        }
        }Console.WriteLine("Thanks for playing");
    }
}