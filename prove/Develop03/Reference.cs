public class Reference
{

    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse = -1;

    public Reference (string book, int chapter, int verse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = -1;
    }

    public Reference (string book, int chapter, int verse, int end){
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = end;
    }

    public string GetReference(){
        if (_endVerse == -1){
            return $"{_book} {_chapter}:{_verse}";
        }
        else{
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }

}