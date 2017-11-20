using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

/*Problem 8. Extract sentences

Write a program that extracts from a given text all sentences containing given word.
Example:

The word is: in

The text is: We are living in a yellow submarine. We don't have anything else. 
Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

Consider that the sentences are separated by . and the words – by non-letter symbols.
 */

class ExtractSentences
{
    static void Main()
    {
        //Console.WriteLine("Enter the text: ");
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days."; //Console.ReadLine();
        string regex = @"\s*(?<sentenceContainingIn>[^\.]*?\bin\b(.|\s)*?\.)";
        MatchCollection matches = Regex.Matches(text, regex, RegexOptions.IgnoreCase);
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Groups["sentenceContainingIn"].Value);
        }
    }
}

