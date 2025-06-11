using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string name = PromptUserName();

        int favNumber = PromtUserNumber();

        int squaredNum = SquareNumber(favNumber);

        DisplayResult(name, squaredNum);
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName() //Asks for and returns the user's name (as a string)
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromtUserNumber() //Asks for and returns the user's favorite number (as an integer)
    {
        Console.Write("What is your favorite number? ");
        string favNumber = Console.ReadLine();
        int IntFavNumber = StringToInt(favNumber); //What do you think Maddie?
        return IntFavNumber;
    }

    static int SquareNumber(int number) //Accepts an integer as a parameter and returns that number squared (as an integer)
    {
        int squaredNum = number * number;
        return squaredNum;
    }

    static void DisplayResult(string name, int squaredNumber) //Accepts the user's name and the squared number and displays them.
    {
        Console.WriteLine(name + ", the square of your number is " + squaredNumber);
    }

    static int StringToInt(string str)
    {
        int changedEntry = int.Parse(str);
        return changedEntry;
    }
}