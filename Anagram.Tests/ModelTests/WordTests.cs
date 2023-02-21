using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;

namespace Anagram.Tests
{
  [TestClass]
  public class WordTests
  {
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
  }
}