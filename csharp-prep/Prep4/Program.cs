using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of number, type 0 to quit.");
        int sum = 0;
        int largestNumber = 0;
        int smallestNumber = 1000;

        while (true)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
            else if (userNumber == 0 )
            {
                break;
            }
        }

        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
            if (numbers[i]  > largestNumber)
            {
                largestNumber = numbers[i];
            }
            if (numbers[i] < smallestNumber & numbers[i] > 0)
            {
                smallestNumber = numbers[i];
            }
        }
        numbers.Sort();
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestNumber}");
        Console.WriteLine("The sorted list is: ");

        for (int i = 0; i < numbers.Count; i++)
        {
            int sortedNumber = numbers[i];
            Console.WriteLine(sortedNumber);
        }


    }
}