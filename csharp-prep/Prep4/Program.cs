using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Enter a list of numbers. Type 0 when finished");

        List<int> numbers = new List<int>();

        int answer = -1;
        while (answer != 0)
        {

            Console.WriteLine("Enter number: ");

            string response = Console.ReadLine();
            answer = int.Parse(response);

            if (answer != 0)
            {
                numbers.Add(answer);
            }

        }

        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }

        Console.WriteLine($"The total is: {total}");

        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int highest = numbers[0];
        foreach (int number in numbers)
        {
           if (number > highest)
           {
            highest = number;
           }
        }

        Console.WriteLine($"The highest number is: {highest}");

        int lowest = numbers[0];
        foreach (int number in numbers)
        {
            if (number < lowest)
            { 
                lowest = number;
            }
        }

        Console.WriteLine($"The lowest number is: {lowest}");
    }
}