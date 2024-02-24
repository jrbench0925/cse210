using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percent? ");
        string percent = Console.ReadLine();

        int grade = int.Parse(percent);
        string letter = "";
        int gradeSign = grade % 10;
        string sign = "";

        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        if (gradeSign >= 7 & grade < 90 & grade >= 60)
        {
            sign = "+";
            letter = letter + sign;
        }

        else if (gradeSign >= 0 & gradeSign <= 3 & grade < 94 & grade >= 60)
        {
            sign = "-";
            letter = letter + sign;
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class");
        }
        else
        {
            Console.WriteLine("Sorry, you didn't pass. Better luck next time!");
        }
    }
}