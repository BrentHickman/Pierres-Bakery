using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;
using System.Collections.Generic;
using System;

namespace Anagram.Tests
{
  [TestClass]
  public class WordTests : IDisposable
  {
    public void Dispose()
    {
      Word.ClearAll();
    }

    [TestMethod]
    public void WordConstructor_CreatesInstanceOfWord_Word()
    {
      Word newWord = new Word("bread");
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }

    [TestMethod]
    public void WordConstructor_ReturnsInputWord_Word()
    {
      string newInput = "bread";
      Word newWord = new Word(newInput);
      string result = newWord.InputWord;
      Assert.AreEqual(newInput, result);
    }

    [TestMethod]
    public void WordConstructor_WritesArrayOfCharactersToConsole_checkWord()
    {
      string newInput = "bread";
      char[] checkArr = {'b', 'r', 'e', 'a', 'd'};
      Word newWord = new Word(newInput);
      char[] newWordArr = newWord.checkWords(newWord.InputWord);
      Assert.AreEqual(newWordArr[0], checkArr[0]);
    }

    [TestMethod]
    public void WordConstructor_CreatesInstanceOfWordinWordList_Word()
    {
      Word newInput1 = new Word("bread");
      Word newInput2 = new Word("fish");
      List<Word> expected = new List<Word> { newInput1, newInput2 };
      List<Word> result = Word.GetAll();
      CollectionAssert.AreEqual(expected, result);    
    }
  }
}