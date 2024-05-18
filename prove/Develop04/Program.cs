using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Mindfulness Activities");
        string choice;

        do {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Please enter your choice: ");
            choice = Console.ReadLine();
            Console.WriteLine("");

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
                Console.WriteLine("Exiting...");
            }
            
            else {
                Console.WriteLine("Invalid choice entered.");
            }

        } while (choice != "4");

    }
}