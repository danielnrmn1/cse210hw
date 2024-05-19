using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private string _text;
    private List<Word> _hiddenWords;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        _hiddenWords = new List<Word>();
    }

    public bool HasHiddenWords()
    {
        return _hiddenWords.Count < CountWords(_text);
    }

    public void HideRandomWords()
    {
        Random random = new Random();

        string[] words = _text.Split(' ');

        int index;
        do
        {
            index = random.Next(words.Length);
        } while (_hiddenWords.Exists(w => w.Index == index));

        _hiddenWords.Add(new Word(index, words[index]));

        words[index] = new string('_', words[index].Length);

        _text = string.Join(" ", words);
    }

public string GetFormattedScripture()
{
    string formattedReference = _reference.GetFormattedReference();
    string formattedText = _text;

    foreach (Word word in _hiddenWords)
    {
        int startIndex = formattedText.IndexOf(word.Value, StringComparison.OrdinalIgnoreCase);

        // Check if the word is found in the scripture text
        if (startIndex >= 0)
        {
            int endIndex = startIndex + word.Value.Length;

            formattedText = formattedText.Remove(startIndex, word.Value.Length).Insert(startIndex, new string('*', word.Value.Length));
        }
    }

    return $"{formattedReference}\n\n{formattedText}";
}

    private static int CountWords(string text)
    {
        return text.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }
}