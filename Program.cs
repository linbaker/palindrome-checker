using System;
using System.Collections.Generic;

namespace Palindromes {

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a word: ");
      string letters = Console.ReadLine().Replace(" ", "");
      Console.WriteLine(letters);
      char[] lettersReversed = letters.ToCharArray();
      Array.Reverse(lettersReversed);
      string wordReversed = new string(lettersReversed);
      if (letters == wordReversed) {
        Console.WriteLine("Palindrome");
      } else {
        Console.WriteLine("Not a Palindrome");
      }
    }
  }

}
