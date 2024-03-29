using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes.Models;
using System.Collections.Generic;

namespace Palindromes.Tests
{
  [TestClass]
  public class PhraseTests
  {
  
    [TestMethod]  
    public void PhraseAssessor_CreatesInstanceOfPhrase_Phrase()
    {
      Phrase newPhrase = new Phrase("hello");
      Assert.AreEqual(typeof(Phrase), newPhrase.GetType()); //string?
    }

    [TestMethod]
    public void GetUserInput_ReturnString_String()
    {
      string userInput = "hello";
      Phrase newPhrase = new Phrase(userInput);
      string result = newPhrase.Input;
      Assert.AreEqual(userInput, result);
    }

    [TestMethod]
    public void SetUserInput_SetsValueOfUserInput_Void()
    {
      Phrase newPhrase = new Phrase("hello");
      string newInput = "goodbye";
      newPhrase.Input = newInput;
      Assert.AreEqual(newInput, newPhrase.Input);
    }
    
    [TestMethod]
    public void StringtoCharList_CreateCharList_List()
    {
      string testString = "hello";
      Phrase testPhrase = new Phrase(testString);
      List<char> testList = testPhrase.StringToCharList();
      List<char> expected = new List<char> { 'h', 'e', 'l', 'l', 'o' };
      CollectionAssert.AreEqual(testList, expected);
    }

    [TestMethod]
    public void ReverseList_ReversCharsInCharList_List()
    {
      Phrase testPhrase = new Phrase("hello");
      List<char> charList = testPhrase.StringToCharList();
      List<char> result = testPhrase.ReverseList(charList);
      List<char> expected = new List<char> {'o', 'l', 'l', 'e', 'h'};
      CollectionAssert.AreEqual(result, expected);
    }

    [TestMethod]
    public void PalindromeChecker_CompareInputToReverseList_Bool()
    {
      Phrase testPhrase = new Phrase("hello");
      List<char> charList = testPhrase.StringToCharList();
      List<char> reverseList = testPhrase.ReverseList(charList);
      bool result = testPhrase.PalindromeChecker(charList, reverseList);
      Assert.IsInstanceOfType(result, typeof(bool));
      Assert.IsFalse(result);
    }
    [TestMethod]
    public void PalindromeChecker_CompareInputToReverseListIsTrue_Bool()
    {
      Phrase testPhrase = new Phrase("hannah");
      List<char> charList = testPhrase.StringToCharList();
      List<char> reverseList = testPhrase.ReverseList(charList);
      bool result = testPhrase.PalindromeChecker(charList, reverseList);
      Assert.IsInstanceOfType(result, typeof(bool));
      Assert.IsTrue(result);
    }
  }
}