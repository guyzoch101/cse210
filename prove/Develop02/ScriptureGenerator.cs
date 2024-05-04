public class ScriptureGenerator {
    public List<string> _scriptures = new List<string>();

    public string GetRandomScripture() {
        _scriptures.Add("1 Nephi 11:17 ~ And I said unto him: I know that he loveth his children; nevertheless, I do not know the meaning of all things.");
        _scriptures.Add("2 Nephi 2:25 ~ Adam fell that men might be; and men are, that they might have joy.");
        _scriptures.Add("Ether 12:4 ~ Wherefore, whoso believeth in God might with surety hope for a better world, yea, even a place at the right hand of God, which hope cometh of faith, maketh an anchor to the souls of men, which would make them sure and steadfast.");
        _scriptures.Add("1 Nephi 1:20 ~ But behold, I, Nephi, will show unto you that the tender mercies of the Lord are over all those whom he hath chosen, because of their faith, to make them mighty even unto the power of deliverance.");
        _scriptures.Add("1 nephi 21:16 ~ Behold, I have graven thee upon the palms of my hands.");
        _scriptures.Add("2 Nephi 32:3 ~ Angels speak by the power of the Holy Ghost; whereofre, they speak the words of Christ. Wherefore, I said unto you, feast upon the words of Christ; for behold, the words of Christ will tell you all things what ye should do.");
        _scriptures.Add("Alma 36:3 ~ Whosoever shall put their trust in God shall be supported in their trials, and their troubles, and their afflictions, and shall be lifted up at the last day.");
        _scriptures.Add("Mosiah 4:9 ~ Believe in God; believe that he is, and that he created all things, both in heaven and in earth; believe that he has all wisdom, and all power, both in heaven and in earth; believe that an doth not comprehend all the things which the Lord can comprehend.");

        Random random = new Random();

        // generate a random index within the range of the list's indices
        int randomIndex = random.Next(_scriptures.Count);
        string randomScripture = _scriptures[randomIndex];

        // returns the random scripture string
        return randomScripture;
    }

    public void DisplayScripture(string scripture) {
        Console.WriteLine(scripture);
    }
}