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
    public void StringToChar_CreateCharArray_Array()
    {
      string testString = "hello";
      Phrase phrase = new Phrase(testString);
      char[] newArray = phrase.StringToChar();
      char[] expected =  { 'h', 'e', 'l', 'l', 'o'};
      CollectionAssert.AreEqual(newArray, expected);
    }



    // [TestMethod]
    // public void ReversePhrase_ReverseUserInput_String()
    // {
    //   Phrase userInput = new Phrase("hello");
    //   string reversedInput = userInput.ReversePhrase();
    //   string expected = new Phrase("olleh");
    //   Assert.AreEqual(reverseInput, expected);
    // }
    

}
  
}