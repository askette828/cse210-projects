using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is you grade percentage? ");
        string userGrade = Console.ReadLine();

        int studentGrade = int.Parse(userGrade);

        int secondDigit = studentGrade % 10;

        if (studentGrade >= 90)
        {
           if (secondDigit >= 3)
            {
                Console.WriteLine("Your grade is A");
            }
            else
            {
                Console.WriteLine("Your grade is A-");
            }
        }

        else if (studentGrade >= 80)
        {
            if (secondDigit >= 7) 
            {
                Console.WriteLine("Your grade is B+");
            }
            else if (secondDigit >= 3 && secondDigit < 6)
            {
                Console.WriteLine("Your grade is B");
            }
            else 
            {
                Console.WriteLine("Your grade is B-");
            }
        }

        else if (studentGrade >= 70)
        {
            if (secondDigit >= 7)
            {
                Console.WriteLine("Your grade is C+");
            }
            else if (secondDigit >= 3 && secondDigit < 6)
            {
                Console.WriteLine("Your grade is C");
            }
            else
            {
                Console.WriteLine("Your grade is C-");
            }
        }

        else if (studentGrade >= 60)
        {
            if (secondDigit >= 7)
            {
                Console.WriteLine("Your grade is D+");
            }
            else if (secondDigit >= 3 && secondDigit < 6)
            {
                Console.WriteLine("Your grade is D");
            }
            else
            {
                Console.WriteLine("Your grade is D-");
            }
        }

        else
        {
            Console.WriteLine("Your grade is F");
        }

        if (studentGrade > 70)
        {
            Console.WriteLine("You have passed this course!");
        }
        else
        {
            Console.WriteLine("You have failed this course!");
        }
    
    }

  
} 