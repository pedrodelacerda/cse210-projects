using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the grade percentage that you want to convert to a letter grade? ");
        string grade = Console.ReadLine();
        double gradePercentage = double.Parse(grade);
        if (gradePercentage >= 90)
        {
            Console.WriteLine("Your letter grade is an A.");
        }
        else if (gradePercentage >= 80)
        {
            Console.WriteLine("Your letter grade is a B.");
        }
        else if (gradePercentage >= 70)
        {
            Console.WriteLine("Your letter grade is a C.");
        }
        else if (gradePercentage >= 60)
        {
            Console.WriteLine("Your letter grade is a D.");
        }
        else
        {
            Console.WriteLine("Your letter grade is an F.");
        }
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the class.");
        }
    }
}