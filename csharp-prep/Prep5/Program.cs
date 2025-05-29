using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        void AddNumbers(int firstNum, int secondNum, string entry)
        {
            int addedNum = firstNum + secondNum;
            Console.WriteLine(entry);
        }

    Console.Write("Enter a string to be printed: ");
    string entry = Console.ReadLine();


    Console.WriteLine("Enter a number: ");
    string firstNum = Console.ReadLine();
    int firstNumInt = int.Parse(firstNum); //Using .toString() and .Parse() we can change variables



    Console.WriteLine("Enter a second number: ");
    string secondNum = Console.ReadLine();  
    int secondNumInt = int.Parse(secondNum);

    AddNumbers(firstNum, secondNum);
    }


}