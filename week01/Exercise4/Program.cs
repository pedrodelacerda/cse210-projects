using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int usernumber = 1;
        int sum = 0;
        int count = 0;
        int largest = int.MinValue;
        int smallest = int.MaxValue;
        List<int> listnumbers = new List<int>();
        while (usernumber != 0)
        {
            Console.WriteLine("Enter a number (0 to quit):");
            usernumber = int.Parse(Console.ReadLine());
            if (usernumber != 0)
            {
                sum += usernumber;
                count++;

                if (usernumber > largest)
                {
                    largest = usernumber;
                }
                if (usernumber < smallest)
                {
                    smallest = usernumber;
                }
                listnumbers.Add(usernumber);
            }
        }
        if (count > 0)
        {
            double average = (double)sum / count;
            Console.WriteLine($"The sum is {sum}");
            Console.WriteLine($"The average is {average}");
            Console.WriteLine($"The largest number is {largest}");
            Console.WriteLine($"The smallest number is {smallest}");
            listnumbers.Sort();
            Console.WriteLine("The numbers in ascending order are:");
            foreach (int number in listnumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}