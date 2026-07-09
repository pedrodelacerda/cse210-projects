using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favNumber = PromptUserNumber();
        int snumber = SquareNumber(favNumber);
        DisplayResult( snumber, userName);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        int favNumber = int.Parse(Console.ReadLine());
        return favNumber;
    }

    static int SquareNumber(int usernumber)
    {
        int squareNumber = usernumber * usernumber;
        return squareNumber;
    }

    static void DisplayResult(int squareNumber, string userName)
    {
        Console.WriteLine($"{userName}, the square of your number is {squareNumber}!");
    }
}

