using System;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();

    }
     public void HideRandomWord(int numberToHide)
    {
        Random rand = new Random();
        int Count = 0;
        
        while (Count < numberToHide && !IsCompletelyHidden())
        {
            int randomIndex = rand.Next(_words.Count);
            if (!_words[randomIndex].IsHidden()) 
            {
                _words[randomIndex].Hide();
                Count++;
            }
        }
    }
    public string GetDisplayText()
    {
        return _reference.GetDisplayText() + " " + string.Join(" ", _words.Select(word => word.GetDisplayText()));
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
