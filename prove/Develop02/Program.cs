using System;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Tristan's Journal");
        string choice;
        // new journal outside of the loop, since only 1 journal is needed
        Journal mainJournal = new Journal();
        PromptGenerator randomPrompt = new PromptGenerator();

        do {
            Console.WriteLine("Menu");
            Console.WriteLine("1. New Entry");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Please select one operatation: ");
            choice = Console.ReadLine();

            if (choice == "1") { // New entry
                // new entry
                Entry newEntry = new Entry();

                // obtain current date
                DateTime theCurrentTime = DateTime.Now;
                newEntry._date = theCurrentTime.ToShortDateString();

                // prompt text
                newEntry._promptText = randomPrompt.GetRandomPrompt();
                Console.WriteLine(newEntry._promptText);

                // entry text
                Console.Write(">> ");
                newEntry._entryText = Console.ReadLine();

                // adding entry to the list under class Journal
                mainJournal.AddEntry(newEntry);

            }

            else if (choice == "2") { // Display entries
                // empty list case handled with an if-else statement
                if (mainJournal._entries.Count != 0) {
                    mainJournal.DisplayAll();
                }
                else {
                    Console.WriteLine("System is empty. Enter new entries or load previous entries.");
                }
            }

            else if (choice == "3") { // Load previous entries from saved text file to a list in class Journal
                // non-existent filename case handled
                Console.WriteLine("Enter the file name without .txt");
                Console.Write("File name to be loaded: ");
                string filename = Console.ReadLine();
                
                if (File.Exists(filename)) {
                    mainJournal.LoadFromFile(filename);
                }
                else {
                    Console.WriteLine($"File  {filename}  does not exist in current folder.");
                }
            }

            else if (choice == "4") { // Save currently entered entries into a text file
                Console.WriteLine("Enter the file name without .txt");
                Console.Write("Name for file of entries entered: ");
                string filename = Console.ReadLine();

                mainJournal.SaveToFile(filename);
            }

            else if (choice == "5") { // Exit
                Console.WriteLine("Exit...");
                Console.WriteLine("See you!");
            }

            else {
                Console.WriteLine("Invalid Choice. Please enter numbers 1 to 5.");
            }

        } while (choice != "5");
    }
}