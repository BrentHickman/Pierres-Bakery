using System;

namespace Anagram.Models
{
  public class Word
  {
    public string InputWord;
    
    public Word(string newInput)
    {
      InputWord = newInput;

    }
    public char[] checkWords(string s)
    {
      char[] ch = new char[s.Length];
      for (int i = 0; i < s.Length; i++)
      { 
        ch[i] = s[i];
      }
      foreach (char c in ch)
      {
        Console.WriteLine(ch[0]);
      }
      return ch;
    }
  }
}