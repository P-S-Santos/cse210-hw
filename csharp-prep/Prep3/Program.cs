using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magNum = randomGenerator.Next(1, 11);
        int num = -1;

        Console.WriteLine("Guess the magic number (1-10)!");

        do {            
            Console.Write("What is your guess? ");
            num = int.Parse(Console.ReadLine());

            if (num < magNum) {
                Console.WriteLine("Too low, go higher.");
            }
            else if (num > magNum) {
                Console.WriteLine("Too high, go lower.");
            }
        } while (num != magNum);

        Console.WriteLine("Good job! You won!");
    }
}