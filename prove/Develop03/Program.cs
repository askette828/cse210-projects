using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please text your message");
        string userPrompt = Console.ReadLine();

        switch(userPrompt)
        {
            case "":
                Scripture.Display();
                Word.ConvertToDashes(Scripture.ConvertToStringArray().ToList());
                break;

            case "quit":
                break;
        }
    }
}