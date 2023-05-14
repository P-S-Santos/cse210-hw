public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void DisplayJournal(){
        foreach (Entry entry in _entries){
            entry.Display();
            Console.WriteLine();
        }  
    }

    public void SaveJournal(){
        Console.WriteLine("Please input the filename you'd like to save onto.");
        Console.Write(" > ");
        string filename = Console.ReadLine();
        
        using (StreamWriter saveFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries){
            saveFile.WriteLine(entry.returnEntry());
            }
        }

        Console.WriteLine($"\nEntries saved in '{filename}'.\n");
    }

    public void LoadJournal(){
        Console.WriteLine("Please input the filename you'd like to load from.");
        Console.Write(" > ");
        string filename = Console.ReadLine();
        
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Entry entry = new Entry();
            string[] parts = line.Split("~|~");
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._entry = parts[2];
            _entries.Add(entry);
        }

        Console.WriteLine($"\nEntries loaded from '{filename}'.\n");
    }
}