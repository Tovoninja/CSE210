
class Word
{



    public void PickWord(Scripture Verse)
    {
        
    Random random = new Random();
    int wordNumber = random.Next(0, Verse.scriptures.Count);
    string word = Verse.scriptures[wordNumber];

    for(int i = 0; i < Verse.scriptures.Count; ++i)
        {
            if(word.Contains("_"))
                {
                    wordNumber = random.Next(0, Verse.scriptures.Count);
                    word = Verse.scriptures[wordNumber];
                }
                else
                {
                    Verse.scriptures[wordNumber] = new string('_' , word.Length);
                }
        }    
    }
}