

class Scripture
{
    public List<string> scriptures = new List<string>();

    public void AddParagraph(string verse)
    {
        string[] newVerse = verse.Split(' ');
        for (int i = 0; i < newVerse.Length; ++i)
        {
            scriptures.Add(newVerse[i]);
        }
    }
}