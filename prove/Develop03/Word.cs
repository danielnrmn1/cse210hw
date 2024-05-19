using System;
using System.Collections.Generic;

public class Word
{
    public int Index { get; }
    public string Value { get; }

    public Word(int index, string value)
    {
        Index = index;
        Value = value;
    }
}