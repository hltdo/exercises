using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 10. Unicode characters

Write a program that converts a string to a sequence of C# Unicode character literals.
Use format strings.
 * 
Example:
input |	output
Hi!	  | \u0048\u0069\u0021
 
 */

class UnicodeCharacters
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.Write("Result: ");

        foreach (char item in input)
        {
            Console.Write(String.Format("\\u{0:x4}", (int)item));
        }

        Console.WriteLine();
    }
}

