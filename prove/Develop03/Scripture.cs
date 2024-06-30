using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // Constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    // Hide a given number of random words
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;
        while (hiddenCount < numberToHide)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }

    // Get the display text of the scripture
    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";
        displayText += string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return displayText;
    }

    // Check if all words are hidden
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}



