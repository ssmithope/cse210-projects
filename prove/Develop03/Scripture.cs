// Scripture class stores the entire scripture,
// The "******" will display hidden words.
class Scripture
{
    private List<Word> words = new List<Word>();
    private Reference reference;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        // Split the text into words and create Word objects.
        words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void GetDisplayText()
    {
        Console.WriteLine(reference.GetDisplayText());
        foreach (var word in words)
        {
            if (word.IsHidden)
                Console.Write("***** ");
            else
                Console.Write($"{word.Text} ");
        }
        Console.WriteLine();
    }

    public void HideRandomWords(int numberToHide)
    {
        var random = new Random();
        var hiddenCount = 0;
        while (hiddenCount < numberToHide)
        {
            var index = random.Next(words.Count);
            if (!words[index].IsHidden)
            {
                words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        return words.All(word => word.IsHidden);
    }
}

