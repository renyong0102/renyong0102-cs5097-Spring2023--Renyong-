using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // create a list of integers
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        // use a foreach loop to iterate through the list and print each number
        Console.Write("Numbers: ");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine();

        // use a for loop to calculate the factorial of each number in the list
        for (int i = 0; i < numbers.Count; i++)
        {
            int factorial = 1;
            for (int j = 1; j <= numbers[i]; j++)
            {
                factorial *= j;
            }
            numbers[i] = factorial;
        }
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }

        // use a lambda expression to print the list of factorials
        // numbers.ForEach(n => Console.Write(n + " "));
    }
}
