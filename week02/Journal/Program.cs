/*
EXCEEDING REQUIREMENTS:
1. Replaced standard text separators with robust JSON persistence (System.Text.Json).
2. Prevents data corruption by automatically handling quotes, commas, and special characters.
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        string choice = "";

        Console.WriteLine("Welcome to the Journal Program!");

        while (choice != "5")
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                // Busca um prompt aleatório
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine($"\nPrompt: {prompt}");
                Console.Write("> ");
                string response = Console.ReadLine();

                // Pega a data atual formatada
                string dateText = DateTime.Now.ToShortDateString();

                // Cria a nova entrada e adiciona ao diário
                JournalEntry entry = new JournalEntry(dateText, prompt, response);
                myJournal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                myJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("\nWhat is the filename? (e.g., journal.json): ");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("\nWhat is the filename? (e.g., journal.json): ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }
            else if (choice == "5")
            {
                Console.WriteLine("\nGoodbye! Keep writing.");
            }
            else
            {
                Console.WriteLine("\nInvalid option. Please enter a number from 1 to 5.");
            }
        }
    }
}