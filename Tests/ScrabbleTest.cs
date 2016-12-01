using Xunit;
using System;
using System.Collections.Generic;
using ScrabbleScore.Objects;

namespace  ScrabbleScore
{
  public class ScrabbleTest
  {
    [Fact]
    public void ScoreCalc_onePoint_true()
    {
      string word = "a";
      int expectedResult = 1;
      Score newScore = new Score(word);
      int wordScore = newScore.ScoreCalc();
      Assert.Equal(true, expectedResult == wordScore);
    }
    [Fact]
    public void ScoreCalc_TwoPoint_true()
    {
      string word = "d";
      int expectedResult = 2;
      Score newScore = new Score(word);
      int wordScore = newScore.ScoreCalc();
      Assert.Equal(true, expectedResult == wordScore);
    }
    [Fact]
    public void ScoreCalc_ThreePoint_true()
    {
      string word = "b";
      int expectedResult = 3;
      Score newScore = new Score(word);
      int wordScore = newScore.ScoreCalc();
      Assert.Equal(true, expectedResult == wordScore);
    }
    [Fact]
    public void ScoreCalc_FourPoint_true()
    {
      string word = "f";
      int expectedResult = 4;
      Score newScore = new Score(word);
      int wordScore = newScore.ScoreCalc();
      Assert.Equal(true, expectedResult == wordScore);
    }
    [Fact]
    public void ScoreCalc_FivePoint_true()
    {
      string word = "k";
      int expectedResult = 5;
      Score newScore = new Score(word);
      int wordScore = newScore.ScoreCalc();
      Assert.Equal(true, expectedResult == wordScore);
    }
    [Fact]
    public void ScoreCalc_EightPoint_true()
    {
      string word = "j";
      int expectedResult = 8;
      Score newScore = new Score(word);
      int wordScore = newScore.ScoreCalc();
      Assert.Equal(true, expectedResult == wordScore);
    }
    [Fact]
    public void ScoreCalc_TenPoint_true()
    {
      string word = "q";
      int expectedResult = 10;
      Score newScore = new Score(word);
      int wordScore = newScore.ScoreCalc();
      Assert.Equal(true, expectedResult == wordScore);
    }
    [Fact]
    public void ScoreCalc_MultipleLetters_true()
    {
      string word = "scrabble";
      int expectedResult = 14;
      Score newScore = new Score(word);
      int wordScore = newScore.ScoreCalc();
      Assert.Equal(true, expectedResult == wordScore);
    }
  }
}
