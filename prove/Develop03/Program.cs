using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Matthew",11,28,30);
        Scripture scripture = new Scripture(reference.GetReference(),"Come unto me, all ye that labour and are heavy laden, and I will give you rest. Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls. For my yoke is easy, and my burden is light.");
        string ans = "";
        int count = 0;

        while (ans != "quit"){
            scripture.Display();
            string text = scripture.GetText();
            count = 0;
            foreach (char c in text){
                if (Char.IsLetter(c)){
                    count += 1;
                }
            }
            if (count > 0){
                Console.Write("(Enter = hide words, 'quit' = close program) ");
                ans = Console.ReadLine();
            }
            else{
                Console.Write("(Enter = close program) ");
                ans = Console.ReadLine();
                ans = "quit";
            }   
            scripture.HideWords();
        }
    }
}