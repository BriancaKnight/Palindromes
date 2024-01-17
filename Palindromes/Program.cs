using System;
using Palindromes.Models;
using System.Collections.Generic;
using Palindromes.UserInterfaceModels;

namespace Palindromes
{
class Program
{
  static void Main()
  {
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(Palindromes.UserInterfaceModels.WelcomeBanner.Welcome);
    Console.WriteLine("Enter a word and I'll tell you if it's a palindrome!");
    string response = Console.ReadLine();
    string userInput = response;
    Phrase testPhrase = new Phrase(userInput);
    Console.WriteLine($"You entered {response}");
    List<char> listResponse = testPhrase.StringToCharList();
    List<char> revResponse = testPhrase.ReverseList(listResponse);
    bool checker = testPhrase.PalindromeChecker(listResponse, revResponse);
    Console.WriteLine($"Is your word a palindrome? {checker}");
    Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
    Console.WriteLine("Do you want to play again? Enter 'y' or 'n'...");
    string again = Console.ReadLine();
    if (again == "y" || again == "Y")
    {
      Main();
    }
    else 
    {
      Console.WriteLine(Palindromes.UserInterfaceModels.GoodbyeBanner.Goodbye);
    }

  }
}
}
