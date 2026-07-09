using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the Magic Number?");
        int magicNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("What is your guess?");
        int guess = int.Parse(Console.ReadLine());
        while (guess != magicNumber)
        {
            if (guess < magicNumber)
            {
                Console.WriteLine("Your guess is too low.");
            }
            else
            {
                Console.WriteLine("Your guess is too high.");
            }
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Congratulations! You guessed! The magic number is {magicNumber}.");
    }
}