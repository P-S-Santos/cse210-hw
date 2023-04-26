using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int largest = -1;
        int sum = 0;
        int ans = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        do{
            Console.Write("Enter number: ");
            ans = int.Parse(Console.ReadLine());
            if (ans != 0){
                numbers.Add(ans);
            }
        }while (ans != 0);

        foreach (int num in numbers){
            sum += num;
            if (num > largest){
                largest = num;
            }
        }

        float avg = (float)sum / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest is: {largest}");
    }
}