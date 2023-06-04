using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment test1 = new Assignment("Jimmy Applesauce", "History");
        Console.WriteLine(test1.GetSummary());
        Console.WriteLine();

        MathAssignment test2 = new MathAssignment("Jane Bananabread", "Algebra", "Section 4.2", "Problems 3-14");
        Console.WriteLine(test2.GetSummary());
        Console.WriteLine(test2.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment test3 = new WritingAssignment("John Coconutpie", "Writing", "The History of Fruit Salad");
        Console.WriteLine(test3.GetSummary());
        Console.WriteLine(test3.GetWritingInfo());
    }
}