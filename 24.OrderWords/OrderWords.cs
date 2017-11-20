using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 24. Order words
Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
 */
class OrderWords
{
    static void Main()
    {

        string input = "Write a program that reads a list of words separated by " +
                       "spaces and prints the list in an alphabetical order";
        string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(words);

        Console.WriteLine("Input:\n" + input);
        Console.WriteLine("\nOutput:\n{0}\n", string.Join(" ", words));
    }
}

