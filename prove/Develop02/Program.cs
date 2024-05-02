using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Journal Program!");
        string choice;

        do {
            Console.WriteLine("Menu");
            Console.WriteLine("1. New Entry");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Please select one operatation: ");
            choice = Console.ReadLine();

            if (choice == "1") {
                // new entry
                Entry newEntry = new Entry();
                PromptGenerator newPrompt = new PromptGenerator();

                // obtain current date
                DateTime theCurrentTime = DateTime.Now;
                newEntry._date = theCurrentTime.ToShortDateString();

                // prompt text
                newEntry._promptText = newPrompt.GetRandomPrompt();

                // entry text
                Console.Write("Enter here... ");
                newEntry._entryText = Console.ReadLine();
            }
            else if (choice == "2") {
                
            }
            else if (choice == "3") {

            }
            else if (choice == "4") {

            }
            else if (choice == "5") {
                Console.WriteLine("Exit...");
            }
            else {
                Console.WriteLine("Invalid Choice");
            }
            Console.WriteLine();

        } while (choice != "5");
    }
}