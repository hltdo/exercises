using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 13. Reverse sentence

Write a program that reverses the words in given sentence.

Example:
input	                               | output
C# is not C++, not PHP and not Delphi! | Delphi not and PHP, not C++ not is C#!
 */
class ReverseSentence
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string text = Console.ReadLine();
        string[] words = text.Split(new char[] { ' ', ',', '.', '?', '!', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);
        string[] nonWords = text.Split(words, StringSplitOptions.RemoveEmptyEntries);

        Array.Reverse(words);

        Console.WriteLine("Result:");
        Console.WriteLine(ReverseTheWords(words, nonWords));
    }

    private static string ReverseTheWords(string[] words, string[] nonWords)
    {
        StringBuilder result = new StringBuilder();
        int maxLength = 0;

        if (words.Length >= nonWords.Length)
        {
            maxLength = words.Length;
        }
        else
        {
            maxLength = nonWords.Length;
        }

        for (int i = 0; i < maxLength; i++)
        {
            if (i < words.Length)
            {
                result.Append(words[i]);
            }

            if (i < nonWords.Length)
            {
                result.Append(nonWords[i]);
            }
        }

        return result.ToString();
    }
}

