using System;
using System.Linq.Expressions;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade_percent = Console.ReadLine();
        int percent = int.Parse(grade_percent);
        int remainder = percent % 10;

        string letter = "";
        string sign = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        if (remainder >= 7 && percent <= 90 && percent >=60)
        {
            sign = "+";
        }
        else if (remainder >= 0 && remainder <= 3 && percent >= 60)
        {
            sign = "-";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}