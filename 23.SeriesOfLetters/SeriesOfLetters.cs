using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 23. Series of letters

Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

Example:
input	                | output
aaaaabbbbbcdddeeeedssaa	| abcdedsa
 */
class SeriesOfLetters
{
    static void Main()
    {
        string input = "aaaaabbbbbcdddeeeedssaa" + "abcdedsa" + "aaaaabbbbbcdddeeeedssaa" + "abcdedsa";
        StringBuilder result = new StringBuilder();

        Console.WriteLine("Result: {0}", ReplaceLetters(input, result));
    }

    private static string ReplaceLetters(string input, StringBuilder result)
    {
        result.Append(input[0]);

        for (int i = 0; i < input.Length - 1; i++)
        {
            if (input[i + 1] != input[i])
            {
                result.Append(input[i + 1]);
            }
        }

        return result.ToString();
    }
}

