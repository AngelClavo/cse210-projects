using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("What is your grade percentage?: ");
        string answer = Console.ReadLine();
        int number = int.Parse(answer);

        string grade_indicator = "";

        if (number >= 90)
        {
            grade_indicator = "A";
        }

        else if (number >= 80)
        {
            grade_indicator = "B";
        }

        else if (number >= 70)
        {
            grade_indicator = "C";
        }

        else if (number >= 60)
        {
            grade_indicator = "D";
        }

        else
        {
            grade_indicator = "F";
        }

        Console.WriteLine($"Your grade is: {grade_indicator}");

        if (number >= 70)
        {
            Console.WriteLine("You approved this course");
        }

        else
        {
            Console.WriteLine("You didn,'t approve this course");
        }

    }
}