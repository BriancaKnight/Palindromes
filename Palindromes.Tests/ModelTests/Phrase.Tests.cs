using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes.Models;

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

    
}
  
}