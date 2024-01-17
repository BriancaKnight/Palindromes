using System;
using Palindromes.Models;
using System.Collections.Generic;

namespace Palindromes
{
class Program
{
  static void Main()
  {
    Console.WriteLine("Enter a word!");
    string response = Console.ReadLine();
    string userInput = response;
    Phrase testPhrase = new Phrase(userInput);
    Console.WriteLine($"You entered {response}");
    List<char> listResponse = testPhrase.StringToCharList();
    List<char> revResponse = testPhrase.ReverseList(listResponse);
    bool checker = testPhrase.PalindromeChecker(listResponse, revResponse);
    Console.WriteLine(checker);
  }
}
}
