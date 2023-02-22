using System;
using System.Collections.Generic;

namespace Anagram.Models
{
  public class Word
  {
    public string InputWord;
    public char[] InputChars;
    public static List<Char> dataList = new List<Char> { };

    public Word(string newInput)
    {
      InputWord = newInput;
    }
    public static void ClearAll()
    {
      dataList.Clear();
    }
    public char[] checkWords(string s)
    {
      char[] ch = new char[s.Length];
      for (int i = 0; i < s.Length; i++)
      {
        ch[i] = s[i];
        // dataList.Add(ch[i]);
        // Console.WriteLine(dataList[i]); 
      }
      Console.WriteLine(ch);
      Array.Sort(ch);
      Console.WriteLine(ch);
      foreach (char c in ch)
      {
        dataList.Add(c);

      }
      Console.WriteLine(dataList[1]);

      return ch;
    }
    public static List<Char> GetAll()
    {
      Console.WriteLine(dataList);
      return dataList;
    }
  }
}