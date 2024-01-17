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
  
}
}

// public char[] StringToChar() 
//   {
//     return Input.ToCharArray();
//   }

//   public char[] ReverseArray(char[] userInput) // ReverseArray(StringToChar(userInput)) (callf() in UI)
//   {
//     char[] reversedPhrase = new char[] { };
//     for (int i = userInput.Length -1; i >= 0; i--)
//     {
//       reversedPhrase.Add(i);
//     }
//     return reversedPhrase;
//   }