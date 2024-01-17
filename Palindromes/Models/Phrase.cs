using System;
using System.Collections.Generic;

namespace Palindromes.Models
{
  public class Phrase
  {
    public string Input { get; set; }

    public Phrase(string userInput)
    {
      Input = userInput;
    }
  
  public char[] StringToChar() //removed input b/c class access?
  {
    return Input.ToCharArray(); //line 11 used prop?
  }
  
  }
}



 //   )
//      reversedPhrase = new Phrase();
//     for (string (userInput.length -1); i <= userInput.length; i--)
//     {
//       reversedPhrase.Add(i);
//     }
//     return reversedPhrase;
//   } 