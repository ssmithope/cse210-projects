// A word class created.
class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public string Display()
    {
        if (_isHidden)
            return new String('_', _text.Length);
        else
            return _text;
    }

    public void Hide()
    {
        _isHidden = true;
    }
}