using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Hello Prep3 World!");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        int guess = -1;

        while (guess != number)
        {
            Console.Write("What is your guess?: ");
            guess = int.Parse(Console.ReadLine());

            if (number > guess)
            {
                Console.WriteLine("Higher");
            }

            else if (number < guess)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("Answer correct");
            }
        }
    }
}