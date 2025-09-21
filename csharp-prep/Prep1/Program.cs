using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("What is your surname?");
        string surname = Console.ReadLine();
        Console.WriteLine($"Your name is {surname}, {name} {surname}.");
    }
}