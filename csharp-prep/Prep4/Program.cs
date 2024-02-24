using System;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Please enter a number (Type 0 to quit). ");
            string response = Console.ReadLine();
            userNumber = int.Parse(response);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }

        }

        int sum = 0;
        int max = numbers[0];

        foreach (int number in numbers)
        {
            sum += number;

            if (number > max)
            {
                max = number;
            }
        }

        float average = ((float)sum / numbers.Count);

        Console.WriteLine($"The sume is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The max is: {max}");

    }
}