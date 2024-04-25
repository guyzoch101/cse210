using System;
using System.Globalization;

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

    static int PromptUserNumber() {
        Console.Write("Please enter your favourite number: ");
        string input = Console.ReadLine();

        int fav_number = int.Parse(input);
        
        return fav_number;
    }

    static int SquareNumber(int number) {
        int squared = number * number;

        return squared;
    }

    static void DisplayResult(string name, int squared_number) {
        Console.WriteLine($"{name}, the square of your number is {squared_number}");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();

        int user_num = PromptUserNumber();

        int squared_number = SquareNumber(user_num);

        DisplayResult(name, squared_number);
    }
}