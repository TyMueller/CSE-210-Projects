using System;
//This program demonstrates how lists are made, used and accesed
class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>(); //We use parentheses whenever we make a new object with list being the class
        float floatNum;
        float sum = 0;
        float average;
        float maxNum;

        do 
        {
            Console.Write("Enter a list of numbers, type 0 when finished: ");
            string strNumber = Console.ReadLine();
            floatNum = float.Parse(strNumber);
            if (floatNum != 0)
                numbers.Add(floatNum);
                sum += floatNum;
        } 
        while (floatNum != 0);

        //Compute sum
        Console.WriteLine($"The sum is: {sum}"); 
        //Compute the average
        Console.WriteLine($"The average is: {average = sum/numbers.Count}");
        //Find largest number
        Console.WriteLine($"The largest is: {maxNum = numbers.Max()}");




    }
}