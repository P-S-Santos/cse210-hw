public class Word
{
    private string _word = "DEFAULT";
    private bool _visible = true;

    public Word(string word){
        _word = word;
    }
    public string GetWord(){
        return _word;
    }

    public bool IsVisible(){
        return _visible;
    }

    public void Hide(){
        _visible = false;
        string blanked = "";
        foreach(char c in _word){
            if (Char.IsLetter(c)){
                blanked += "_";
            }
            else{
                blanked += c;
            }   
        }
        _word = blanked;
    }
}