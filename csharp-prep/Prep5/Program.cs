using System;

class Program
{
    static void DisplayWelcome() {
        Console.WriteLine("Hello World!");
    }

    static string PromptUserName() {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static void Main(string[] args)
    {
        DisplayWelcome();

        PromptUserName();
    }
}