using System;
using System.Collections.Generic;
using System.Linq;


namespace Palindromes.Models
{
  public class Phrase
  {
    public string Input { get; set; }

    public Phrase(string userInput)
    {
      Input = userInput;
    }
  public List<char> StringToCharList()
  {
    return Input.ToList(); //should split str to char list.
  }

  public List<char> ReverseList(List<char> userInput)
  {
    List<char> reversedPhrase = new List<char> { };
    for (int i = userInput.Count -1; i >= 0; i--)
    {
      reversedPhrase.Add(userInput[i]);
    }
    return reversedPhrase;
  }
  
}
}

// ReverseArray(StringToChar(userInput)) (callf() in UI)