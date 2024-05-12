using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // declaring the variables in Main
        Reference scriptureInfo;
        string verseContent;
        Scripture scripture;

        Random random = new Random();
        int selector = random.Next(4); // randomly generates an integer between 0 and 3

        if (selector == 0) {
            scriptureInfo = new Reference("John", 3, 16);
            verseContent = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
            scripture = new Scripture(scriptureInfo, verseContent);
        }
        else if (selector == 1) {
            scriptureInfo = new Reference("Proverbs", 3, 5, 6);
            verseContent = "5 Trust in the LORD with all thine heart; and lean not unto thine own understanding. 6 In all they ways acknowledge him, and he shall direct thy paths.";
            scripture = new Scripture(scriptureInfo, verseContent);
        }
        else if (selector == 2) {
            scriptureInfo = new Reference("1 Nephi", 3, 7);
            verseContent = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I knwo that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth.";
            scripture = new Scripture(scriptureInfo, verseContent);
        }
        else {
            scriptureInfo = new Reference("Matthew", 11, 28);
            verseContent = "Come unto me, all ye that labour and are heavy laden, and I will give you rest.";
            scripture = new Scripture(scriptureInfo, verseContent);
        }

        // displaying the scripture in full initially
        Console.WriteLine("Original Scripture:");
        Console.WriteLine($"{scriptureInfo.GetDisplayText()}  {scripture.GetDisplayText()}");
        Console.WriteLine("");

        while (!scripture.IsCompletelyHidden()) {
            Console.WriteLine("Press Enter to hide more words, or type 'quit' to exit:");
            string input = Console.ReadLine();
            Console.Clear();

            if (input.ToLower() == "quit") {
                Console.WriteLine("Exiting...");
                break;
            }

            // Console cleared and will display the new scripture string with more words hidden
            int hideWordsInteger = random.Next(5) + 1; // randomly generates an integer between 1 to 5
            scripture.HideRandomWords(hideWordsInteger);
            Console.WriteLine($"{scriptureInfo.GetDisplayText()}  {scripture.GetDisplayText()}");
            Console.WriteLine("");
        } // exits the loop when all words are hidden

        Console.WriteLine("All words are hidden. Press any key to exit.");
        Console.ReadKey(); // exits the program when an arbitrary key is pressed
    }
}