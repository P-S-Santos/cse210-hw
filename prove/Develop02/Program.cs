// How I've attempted to exceed core reqs:
// 1. Made it so the prompt generation is more modular and provides a larger variety of questions by mixing and matching phrases.
// 2. Added the ability to record prompt-free entries together with the prompted ones.

using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        Prompt prompt = new Prompt();
        Journal journal = new Journal();
        Random rng = new Random();

        Console.WriteLine("\nWelcome to the Journal App!\n");
        string menu = "";
        do{
            Console.WriteLine(" ~~ MAIN MENU ~~");
            Console.WriteLine("Type '1' to write a prompted entry");
            Console.WriteLine("Type '2' to write a free entry");
            Console.WriteLine("Type '3' to view your entries");
            Console.WriteLine("Type '4' to save your entries onto a file");
            Console.WriteLine("Type '5' to load entries from a file");
            Console.WriteLine("Type '0' to close the program.");
            Console.Write(" > ");
            menu = Console.ReadLine();
            Console.WriteLine();
            
            switch(menu){
                case "1":
                    Entry entry = new Entry();
                    int randAdj = rng.Next(prompt._adj1.Length);
                    int randVerb = rng.Next(prompt._verb.Length);
                    
                    entry._prompt = $"Prompt: What is {prompt._adj1[randAdj]} {prompt._verb[randVerb]} today?";                                      
                    Console.WriteLine(entry._prompt);
                    Console.Write(" > ");
                    entry._entry = Console.ReadLine();


                    journal._entries.Add(entry);
                    Console.WriteLine("\nEntry recorded.\n");

                    menu = "";
                    break;

                case "2":
                    entry = new Entry();
                    
                    entry._prompt = "Free entry";                                      
                    Console.WriteLine("Free entry:");
                    Console.Write(" > ");
                    entry._entry = Console.ReadLine();
                    
                    journal._entries.Add(entry);
                    Console.WriteLine("\nEntry recorded.\n");                    
                    
                    menu = "";
                    break;

                case "3":
                    Console.WriteLine("Displaying entries...\n");
                    journal.DisplayJournal();
                    menu = "";
                    break;
                
                case "4":
                    journal.SaveJournal();
                    menu = "";
                    break;

                case "5":
                    journal.LoadJournal();
                    menu = "";
                    break;

                case "0":
                    Console.WriteLine("Thanks for using the Journal App. See you tomorrow!\n");
                    break;
                
                default:
                    menu = "";
                    break;
            }    
        } while(menu != "0");
    }
}