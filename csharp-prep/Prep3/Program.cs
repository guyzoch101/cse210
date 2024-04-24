using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 100);
        
        int guess_number;
        do {

            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            guess_number = int.Parse(guess);

            if (magic_number > guess_number) {
                Console.WriteLine("Higher");
            }
            else if (magic_number < guess_number) {
                Console.WriteLine("Lower");
            }

        } while (magic_number != guess_number);

        Console.WriteLine("You guessed it!");
    }
}