/* CREATIVITY REQUIREMENTS:
 * 1. Scripture Library: Loads a collection of scriptures (single and multi-verse) and selects one at random upon execution.
 * 2. Smart Word Hiding: Selects only from words that are not yet hidden, ensuring efficient progression each turn.
 */

using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Scripture> library = new List<Scripture>
            {
                new Scripture(
                    new Reference("John", 3, 16),
                    "For God so loved the world that he gave his one and only Son that whoever believes in him shall not perish but have eternal life."
                ),
                new Scripture(
                    new Reference("Proverbs", 3, 5, 6),
                    "Trust in the LORD with all your heart and lean not on your own understanding in all your ways submit to him and he will make your paths straight."
                ),
                new Scripture(
                    new Reference("Philippians", 4, 13),
                    "I can do all this through him who gives me strength."
                )
            };

            Random random = new Random();
            Scripture currentScripture = library[random.Next(library.Count)];

            while (true)
            {
                Console.Clear();
                Console.WriteLine(currentScripture.GetDisplayText());
                Console.WriteLine();

                if (currentScripture.IsCompletelyHidden())
                {
                    break;
                }

                Console.Write("Press Enter to continue or type 'quit' to finish: ");
                string input = Console.ReadLine();

                if (input.Trim().ToLower() == "quit")
                {
                    break;
                }

                currentScripture.HideRandomWords(3);
            }
        }
    }
}