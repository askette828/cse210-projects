using System;

class Program
{
    static void Main(string[] args)
    {
        int i, magicNum, num = 0;
        string ans; 
        do
        {
            i = 1;
            Console.Write("What is your magic number? ");
            magicNum = int.Parse(Console.ReadLine());

            Console.Write("What is your guess? ");
            num = int.Parse(Console.ReadLine());

            while (magicNum != num)
            {
                if (magicNum > num)
                {
                    Console.WriteLine("Higer");
                    Console.Write("What is your guess? ");
                    num = int.Parse(Console.ReadLine());
                    i++;

                }
                else
                {
                    Console.WriteLine("Lower");
                    Console.Write("What is your guess? ");
                    num = int.Parse(Console.ReadLine());
                    i++;
                }
            }
            Console.WriteLine($"You guessed it! You have tried {i} times. Would you like to play again? ");
            ans = Console.ReadLine();
        }
        while (ans == "yes");
    }
}