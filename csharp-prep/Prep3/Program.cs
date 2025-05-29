using System;
//This program is a guessing game that generates a random number within a given range
class Program
{
    static void Main(string[] args)
    {
        bool correct = false;
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        Console.WriteLine("The number will be between 1 and 100");

        while (correct == false)
        {
            Console.Write("Guess the number: ");
            string strGuess =  Console.ReadLine();
            int intGuess = int.Parse(strGuess); 
           
            if (intGuess == number)
            {
                Console.WriteLine("You got it!");
                correct = true;
            }
            else if (intGuess > number)
            {
                Console.WriteLine("Your guess was too high");
            }
            else
            {
                Console.WriteLine("Your guess was too low");
            }}
        

    }
}