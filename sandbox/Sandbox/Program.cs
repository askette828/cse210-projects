using System;

class Program
{
    static int Adder(int a, int b)
    {
        return a+b;
    }
    static void Greeting(string firstName)
    {
        Console.WriteLine($"Hello {firstName}");
    }
    static void Main(string[] args)
    {
        int x = 5;
        int y = 2;
        int sum = Adder(x, y);
        Console.WriteLine(sum);
        string someoneName = "Elliot";
        Greeting(someoneName);
    }
}