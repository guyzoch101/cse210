using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        string status;
        do {
            Random randomGenerator = new Random();
            int magic_number = randomGenerator.Next(1, 101);
        
            int attempt = 0;
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

                attempt += 1;

            } while (magic_number != guess_number);

            Console.WriteLine("You guessed it!");
            Console.WriteLine($"Attempts used: {attempt}");
        
            Console.Write("Continue? (yes / no) ");
            status = Console.ReadLine();

        } while (status == "yes");
    }
}