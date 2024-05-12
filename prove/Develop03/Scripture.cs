public class Scripture {
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text) {
        _reference = reference;
        // split up the words in the text and store each as a word object in the list _words
        string[] words = text.Split(" ");
        foreach (string singleWord in words) {
            Word newWord = new Word(singleWord);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide) {
        Random random = new Random();
        int totalWords = _words.Count;

        if (numberToHide > totalWords) {
            numberToHide = totalWords;
        }

        int wordsHidden = 0;
        while (wordsHidden < numberToHide) {
            int indexToHide = random.Next(totalWords);
            if (!_words[indexToHide].IsHidden()) {
                _words[indexToHide].Hide();
                wordsHidden += 1;
            }
        }
    }

    public string GetDisplayText() {
        string display = "";

        foreach (Word word in _words) {
            if (word.IsHidden()) {
                string hiddenString = "";
                foreach (char c in word.GetDisplayText()) {
                    hiddenString += "_";
                }
                display = $"{display}{hiddenString} ";
            }
            else {
                display += word.GetDisplayText() + " ";
            }
        }
        return display.Trim();
    }

    public bool IsCompletelyHidden() {
        foreach (Word word in _words) {
            if (!word.IsHidden()) {
                return false;
            }
        }
        return true;
    }
}