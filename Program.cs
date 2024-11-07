using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // random number generator and number list
        Random rnd = new Random();
        List<int> numbers = new List<int>();

        // generate 10 random numbers and add them to the list (range -50 to 50)
        for (int i = 0; i < 10; i++)
        {
            numbers.Add(rnd.Next(-50, 51));
        }

        // display the original list
        Console.WriteLine("Original List: " + string.Join(", ", numbers));

        // even numbers
        var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
        Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));

        // odd numbers
        var oddNumbers = numbers.Where(n => n % 2 != 0).ToList();
        Console.WriteLine("Odd Numbers: " + string.Join(", ", oddNumbers));

        // negative numbers
        var negativeNumbers = numbers.Where(n => n < 0).ToList();
        Console.WriteLine("Negative Numbers: " + string.Join(", ", negativeNumbers));

        // positive numbers
        var positiveNumbers = numbers.Where(n => n > 0).ToList();
        Console.WriteLine("Positive Numbers: " + string.Join(", ", positiveNumbers));

        // numbers greater than 15 and less than 22
        var rangeNumbers = numbers.Where(n => n > 15 && n < 22).ToList();
        Console.WriteLine("Numbers greater than 15 and less than 22: " + string.Join(", ", rangeNumbers));

        // square of each number
        var squares = numbers.Select(n => n * n).ToList();
        Console.WriteLine("Square of each number: " + string.Join(", ", squares));
    }
}
