namespace Palindromes.Models
{
  public class Phrase
  {
    public string Input { get; set; }
    public Phrase(string userInput)
    {
      Input = userInput;
    }
  
  }
}