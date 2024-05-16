// A scripture class created.
class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(string reference, string text)
    {
        _reference = new Reference(reference);
        _words = new List<Word>();

        foreach (string word in text.Split(' '))
            _words.Add(new Word(word));
    }

    public void Display()
    {
        Console.WriteLine(_reference.Text);
        foreach (Word word in _words)
            Console.Write(word.Display() + " ");
        Console.WriteLine();
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        int index = random.Next(_words.Count);
        _words[index].Hide();
    }
}