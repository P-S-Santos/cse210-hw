public class Scripture
{
    private string _reference;
    private List<Word> _excerpt = new List<Word>();

    public Scripture(string reference, string text){
        _reference = reference;
        string[] words = text.Split(' ');
        foreach (string word in words){
            Word newWord = new Word(word);
            _excerpt.Add(newWord);
        }
    }

    public void HideWords(){
        Random rand = new Random();
        for (int i = 0; i < 5; i++){
            int ind = rand.Next(_excerpt.Count);
            _excerpt[ind].Hide();
        }
    }

    public string GetText(){
        string fullText = "";
        foreach (Word word in _excerpt){
            fullText += word.GetWord()+" ";
        }
        return fullText;
    }

    public void Display(){
        Console.Clear();
        Console.WriteLine(_reference);
        foreach (Word word in _excerpt){
            Console.Write(word.GetWord()+" ");
        }
        Console.WriteLine();
    }

}