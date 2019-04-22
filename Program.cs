using System;
using System.Collections.Generic;

namespace Palindromes {

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a word: ");
      string userInput = Console.ReadLine();
      char[] letters = userInput.ToCharArray();
      char[] lettersReversed = userInput.ToCharArray();
      Array.Reverse(lettersReversed);
      string word = new string(letters);
      string wordReversed = new string(lettersReversed);
      if (word == wordReversed) {
        Console.WriteLine("Palindrome");
      } else {
        Console.WriteLine("Not a Palindrome");
      }
    }
  }

}
