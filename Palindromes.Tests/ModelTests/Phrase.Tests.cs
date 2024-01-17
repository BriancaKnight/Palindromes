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
      Phrase newPhrase = new Phrase();
      Assert.AreEqual(typeof(Phrase), newPhrase.GetType()); //string?
    }
}
  
}