using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        int square = SquareNumber(num);
        DisplayResult(name, square);

    }
        static void DisplayWelcome(){
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName(){
            Console.Write("What's your name? ");
            return Console.ReadLine();
        }

        static int PromptUserNumber(){
            Console.Write("What's your favorite number? ");
            return int.Parse(Console.ReadLine());
        }
        
        static int SquareNumber(int num){
            return (num * num);
        }

        static void DisplayResult(string name, int square){
            Console.WriteLine($"{name}, the square of your number is {square}.");
        }

}