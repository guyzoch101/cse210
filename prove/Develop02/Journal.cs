public class Journal {
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry) {
        _entries.Add(newEntry);
    }

    public void DisplayAll() {
        foreach (Entry entry in _entries) {
            entry.Display();
        }
    }

    public void SaveToFile(string filename) {
        using(StreamWriter entriesFile = new StreamWriter($"{filename}.txt")) {
            foreach (Entry entry in _entries) {
            entriesFile.WriteLine($"{entry._date}~{entry._promptText}~{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string filename) {
        string[] lines = System.IO.File.ReadAllLines($"{filename}.txt");

        foreach (string line in lines) {
            string[] parts = line.Split("~");

            Entry entryLoading = new Entry();
            int dateINDEX = 0;
            int promptTextINDEX = 1;
            int entryTextINDEX = 2;

            entryLoading._date = parts[dateINDEX];
            entryLoading._promptText = parts[promptTextINDEX];
            entryLoading._entryText = parts[entryTextINDEX];

            AddEntry(entryLoading);
        }
    }
}