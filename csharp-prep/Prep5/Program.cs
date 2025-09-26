using System;
using System.Configuration.Assemblies;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        PromptUserName();
        PromptUserNumber();
        PromptUserBirthYear();

        Console.WriteLine($"{PromptUserName}, the square of your number is {squareNumber}");

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int x = int.Parse(Console.ReadLine());
        return x * x;
    }

    static int PromptUserBirthYear()
    {
        Console.Write("Please enter the year you were born: ");
        int x = int.Parse(Console.ReadLine());
        return x;
    }

    static int squareNumber(int x)
    {
        return x * x;
    }
}