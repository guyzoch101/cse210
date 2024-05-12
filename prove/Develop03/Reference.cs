using System.ComponentModel.DataAnnotations;

public class Reference {
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse) {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0; // setting _endVerse as 0 since only 1 verse is provided
    }

    public Reference(string book, int chapter, int startVerse, int endVerse) {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText() {
        string display;

        if (_endVerse == 0) { // case for only 1 verse
            display = $"{_book} {_chapter}:{_verse}";
        }
        else { // other cases: verse range
            display = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }

        return display;
    }
}