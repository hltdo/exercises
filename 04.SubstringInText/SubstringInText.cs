using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 4. Sub-string in text
    Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
  
    Example:
    
    The target sub-string is 'in'
    The text is as follows: We are living in an yellow submarine. We don't have anything else.
    inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

    The result is: 9
 */

class SubstringInText
{
    static void Main()
    {
        //Console.WriteLine("Enter some text: ");
        string text = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days."; //Console.ReadLine();
        //Console.WriteLine("Enter the target substring: ");
        text = text.ToLower();
        string substring = "in"; //Console.ReadLine();
        substring = substring.ToLower();
        int counter = CountSubstring(text, substring);

        Console.WriteLine("'{0}' is repeated {1} times in the text.", substring, counter);
    }

    private static int CountSubstring(string text, string substring)
    {
        int index = 0;
        int counter = 0;
        while (true)
        {
            int found = text.IndexOf(substring, index);
            if (found < 0)
            {
                break;
            }
            counter++;
            index = found + 1;
        }
        return counter;
    }

}

