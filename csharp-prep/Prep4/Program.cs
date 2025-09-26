using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }
        int positiveMin = numbers.Where(n => n > 0).Min(); 
        Console.WriteLine("The sum is " + numbers.Sum());
        Console.WriteLine("The average is " + numbers.Average());
        Console.WriteLine("The largest number is " + numbers.Max());
        Console.WriteLine($"The smallest positive number is {positiveMin}");
        Console.WriteLine(" The sorted list is:");

        numbers.Sort();
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

    }
}