public class Scripture {
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text) {
        _reference = reference;

        // split up the words in the text and becomes a string array
        // an item in the array contains 1 word, including punctuation associated
        string[] words = text.Split(" ");

        // each item in the array is stored into class Word and stores into _words under class Scripture
        foreach (string singleWord in words) {
            Word newWord = new Word(singleWord);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide) {
        Random random = new Random();
        int totalWords = _words.Count; // total number of words in the verse

        // counts the number of words not yet been hidden
        int wordsNotHidden = 0;
        foreach (Word word in _words) {
            if (!word.IsHidden()) {
                wordsNotHidden += 1;
            }
        }

        if (numberToHide > totalWords) {
            numberToHide = totalWords; // limits the numberToHide
        }
        else if (numberToHide > wordsNotHidden) {
            numberToHide = wordsNotHidden; // limits the numberToHide
        }

        int wordsHidden = 0; // number of words hidden counter

        while (wordsHidden < numberToHide) {

            // randomly generates an integer within the limit of the number of words in the verse string
            int indexToHide = random.Next(totalWords); 

            // checks if the word has already been hidden
            // if not, it will be hidden through the Hide method
            // if already been hidden, it will skip over and generate another integer to hide a word
            if (!_words[indexToHide].IsHidden()) {
                _words[indexToHide].Hide();
                wordsHidden += 1;
            }
        }
    }

    public string GetDisplayText() {
        string display = "";

        // forming the display string
        foreach (Word word in _words) {
            
            // if the word has been hidden, the loop iterates every character of the word and converts each of them into _
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
        return display.Trim(); // clears any spaces in the end
    }

    public bool IsCompletelyHidden() {
        // if one word is not hidden (being displayed), returns false, lets the program continue
        foreach (Word word in _words) {
            if (!word.IsHidden()) {
                return false;
            }
        }
        return true;
    }
}