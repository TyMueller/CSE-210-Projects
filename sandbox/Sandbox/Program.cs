using System;

class Program
{
    public class Blind
    {
        public double _blindWidth;
        public double _blindHeight;
        public string _blindColor;

        public double GetArea()
        {
            return _blindHeight * _blindHeight;
        }
    }
    static void Main(string[] args)
    {/*
        static int AddNumbers(int firstNum, int secondNum, string entry) //When do we need to put "static"?
        {
            int addedNum = firstNum + secondNum;
            int subNums = secondNum - firstNum;
            Console.WriteLine(entry);
            return addedNum;
            //return subNums; //Can you return more than 1 thing at a time?
        }

        Console.Write("Enter a string to be printed: ");
        string entry = Console.ReadLine();


        Console.Write("Enter a number: ");
        string firstNum = Console.ReadLine();
        int firstNumInt = int.Parse(firstNum); //Using .toString() and .Parse() we can change variables



        Console.Write("Enter a second number: ");
        string secondNum = Console.ReadLine();
        int secondNumInt = int.Parse(secondNum);

        int test = AddNumbers(firstNumInt, secondNumInt, entry);
        Console.Write(test); //Is this the right way to do this?
    */

        Blind kitchen = new Blind();
        kitchen._blindWidth = 10; //Why is this not assigning?
        Console.Write(kitchen._blindWidth);

    }
}