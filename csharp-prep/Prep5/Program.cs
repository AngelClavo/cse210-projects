using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        display_welcome();
        string name = written_name();
        int number = written_number();
        int number_square = new_number(number);
        answer(name, number_square);
    }

    static void display_welcome()
    {
        Console.WriteLine("Welcome to the program");
    }

    static string written_name()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int written_number()
    {
        Console.Write("Enter the number you chose, please: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int new_number(int number)
    {
        int square = number * number;
        return square;
    }

    static void answer(string name, int number_square)
    {
        Console.WriteLine($"{name}, the square of your number is: {number_square}");
    }

}