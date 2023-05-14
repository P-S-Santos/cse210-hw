public class Entry
{
    public string _date = (DateTime.Now).ToShortDateString();
    public string _prompt;
    public string _entry;
    public void Display(){
        Console.WriteLine($"[{_date}] {_prompt}");
        Console.WriteLine($" > {_entry}");
    }
    public string returnEntry(){
        return $"{_date}~|~{_prompt}~|~{_entry}";
    }

}