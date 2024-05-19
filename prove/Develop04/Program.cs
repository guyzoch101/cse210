using System;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.IO;

// for ListingActivity, all the user's responses will be saved in a textfile called ListingActivityResponses.txt
// in ReflectingActivity, 2 new lists are declared to keep track of the number generated for the randomPrompt and randomQuestions
// to prevent generating a duplicated prompt or question
// added a function to create an acitvity log: recording the time, activity done, and duration done
// added another function to record the responses made by the user in the ListingActivity

class Program
{
    static void Main(string[] args)
    {
        string choice;

        do {
            Console.WriteLine("Menu : Mindfulness Activities");
            Console.WriteLine("     1. Breathing Activity");
            Console.WriteLine("     2. Listing Activity");
            Console.WriteLine("     3. Reflecting Activity");
            Console.WriteLine("     4. Exit");
            Console.Write("Please enter your choice: ");
            choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1") {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            
            else if (choice == "2") {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }

            else if (choice == "3") {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }

            else if (choice == "4") {
                Activity activity = new Activity();
                activity.ShowSpinner(5);
                Console.WriteLine("Exiting...");
            }
            
            else {
                Console.WriteLine("Invalid choice entered.");
            }

        } while (choice != "4");

    }
}