using System;
/*Write a program that determines the letter grade for a course according to the following scale:
A >= 90
B >= 80
C >= 70
D >= 60
F < 60
*/
class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your GPA? ");
        string stringGPA = Console.ReadLine(); //Can we get ints returned or only strings?
        int intGPA = int.Parse(stringGPA);
        string letter = "";
        
        if (intGPA >= 90)
        {
            letter = "A";
            Console.WriteLine("You got an A!");
        }
        else if (intGPA >= 80)
        {
            letter = "B";
            Console.WriteLine("You got a B!");
        }
        else if (intGPA >=70)
        {
            letter = "C";
        }
        else if (intGPA >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"You got a {letter}");
        if (intGPA >= 70)
        {
            Console.WriteLine("You passed! Nice job!");
        }
        else
        {
            Console.WriteLine("Try again next time champ.");
        }

    }
}