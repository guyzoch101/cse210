using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int num;

        do {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();

            num = int.Parse(input);
            numbers.Add(num);
        } while (num != 0);

        int sum = 0;
        foreach (int number in numbers) {
            sum += number;
        }

        int terms = numbers.Count;
        float average = sum / terms;

        int max = 0;
        foreach (int number in numbers) {
            if (max < number) {
                max = number;
            }
        }

        int min_positive = 10000;
        foreach (int number in numbers) {
            if (min_positive > number && number > 0) {
                min_positive = number;
            }
        }

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {max}");
        Console.WriteLine($"The smallest positive number is: {min_positive}");
    }
}