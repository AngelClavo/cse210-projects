using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");

        int userChoice = 0;

        Journal journalFile = new Journal();

        while (userChoice != 5)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            string userChoiceString = Console.ReadLine();
            userChoice = int.Parse(userChoiceString);

            Console.WriteLine("");

            if (userChoice == 1)
            {
                Console.WriteLine("");
                Entry newEntry = new Entry();
                PromptGenerator newPrompt = new PromptGenerator();


                newEntry._promptText = newPrompt.GetRandomPrompt();
                Console.WriteLine(newEntry._promptText);
                newEntry._entryText = Console.ReadLine();
                newEntry._date = newEntry.GetDateTime();

                journalFile.AddEntry(newEntry);
            }

            else if (userChoice == 2)
            {
                Console.WriteLine("");
                journalFile.DisplayAll();
            }

            else if (userChoice == 3)
            {
                Console.WriteLine("");
                Console.WriteLine("\nWhat is the name of the journal? ");
                string file = Console.ReadLine();
                journalFile.SaveToFile(file);
            }

            else if (userChoice == 4)
            {
                Console.WriteLine("");
                Console.WriteLine("\nWhat is the name of the journal? ");
                string file = Console.ReadLine();
                journalFile.LoadFromFile(file);
                Console.WriteLine("Wait a moment... ");
                journalFile.DisplayAll();
            }

            else if (userChoice == 5)
            {
                Console.WriteLine("");
            }

            else
            {
                Console.WriteLine("Wrong option. Please check again");
            }
            

        };

        Console.WriteLine("");
    }
}