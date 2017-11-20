using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 21. Letters count

Write a program that reads a string from the console and prints all different letters in the string
along with information how many times each letter is found.
 */

class LettersCount
{
    static void Main()
    {
        Console.WriteLine("Enter the string:");
        string input = Console.ReadLine().ToLower();
        int[] allLetters = new int[26];

        PresentingTheResult(CountTheLetters(input, allLetters));
    }

    private static void PresentingTheResult(int[] allLetters)
    {
        for (int i = 0; i < allLetters.Length; i++)
        {
            if (allLetters[i] > 0)
            {
                Console.WriteLine("Letter '{0}' appears {1} time(s) in the text.", (char)(i + 'a'), allLetters[i]);
            }
        }
    }

    private static int[] CountTheLetters(string input, int[] allLetters)
    {
        foreach (char item in input)
        {
            if (Char.IsLetter(item))
            {
                allLetters[item - 'a']++;
            }
        }

        return allLetters;
    }
}

