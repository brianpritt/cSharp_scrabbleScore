using System;
using System.Collections.Generic;

namespace ScrabbleScore.Objects
{
  public class Score
  {
    public string ScrabbleWord {get; set;}
    public int WordScore {get; set;}

    public Score(string scrabbleWord)
    {
      this.ScrabbleWord = scrabbleWord;
      this.WordScore = 0;

    }
    public int ScoreCalc()
    {
      Dictionary<int, List<char>> scoreList = new Dictionary<int, List<char>>()
      {
        {1,new List<char> {'a','e','i','o','u','l','n','r','s','t'}},
        {2, new List<char> {'d','g'}},
        {3, new List<char> {'b','c','m','p'}},
        {4, new List<char> {'f','h','v','w','y'}},
        {5, new List<char> {'k'}},
        {8, new List<char> {'j','x'}},
        {10, new List<char> {'q','z'}}
      };
      foreach (char letter in ScrabbleWord)
      {
        foreach (var kvp in scoreList)
        {
          for (int v = 0; v < kvp.Value.Count; v++)
            if (letter == kvp.Value[v])
            {
              WordScore += kvp.Key;
            }
          }
        }
        return WordScore;
      }
    }
  }
