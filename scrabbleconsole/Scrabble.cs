﻿using System;
using System.Collections.Generic;

public class Scrabble
{
    private readonly string _word;
    private static readonly Dictionary<char, int> LetterValues = new Dictionary<char, int>
    {
        {'A', 1}, {'E', 1}, {'I', 1}, {'O', 1}, {'U', 1}, {'L', 1}, {'N', 1}, {'R', 1}, {'S', 1}, {'T', 1},
        {'D', 2}, {'G', 2},
        {'B', 3}, {'C', 3}, {'M', 3}, {'P', 3},
        {'F', 4}, {'H', 4}, {'V', 4}, {'W', 4}, {'Y', 4},
        {'K', 5},
        {'J', 8}, {'X', 8},
        {'Q', 10}, {'Z', 10}
    };

    public Scrabble(string word)
    {
        _word = word.ToUpper();
    }

    public int Score()
    {
        int score = 0;
        foreach (char letter in _word)
        {
            if (LetterValues.ContainsKey(letter))
            {
                score += LetterValues[letter];
            }
        }
        return score;
    }
}