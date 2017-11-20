using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 6. String length
 Write a program that reads from the console a string of maximum 20 characters.
 If the length of the string is less than 20, the rest of the characters should be filled with *.
 Print the result string into the console.
 */
class StringLength
{
    static void Main()
    {
        Console.WriteLine("Enter a text containing up to 20 characters: ");
        StringBuilder input = new StringBuilder(Console.ReadLine());
        while (input.Length != 20)
        {
            if (input.Length>20)
            {
                Console.WriteLine("Too long text. Please, enter a text containing up to 20 characters: ");
                input = new StringBuilder(Console.ReadLine());
            }
            else
            {
                while (input.Length<20)
                {
                    input.Append("*");
                }
            }
        }
        Console.WriteLine(input);
    }
}

