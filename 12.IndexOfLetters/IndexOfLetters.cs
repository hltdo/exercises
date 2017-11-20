using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 12. Index of letters
Write a program that creates an array containing all letters from the alphabet (A-Z).
Read a word from the console and print the index of each of its letters in the array.
 */
class IndexOfLetters
{
    static void Main(string[] args)
    {
        int letters = 26;
        char[] alphabet = new char[letters];
        int length = alphabet.Length;
        int start = 65; // Letter 'A' has a decimal representaion of 65

        //Assigning letters of the alphabet in the array
        for (int i = 0; i < length; i++)
        {
            alphabet[i] = (char)start;
            start++;
        }

        Console.WriteLine("Write a word: ");
        string input = Console.ReadLine();
        string word = input.ToUpper();
        //Initializing a new array to store the indeces of the letters;
        int[] index = new int[word.Length];
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                if (word[i]==alphabet[j])
                {
                    index[i] = Array.IndexOf(alphabet, alphabet[j]);
                }
            }
        }

        Console.WriteLine("Corresponding indices of the word \"{0}\"", input);
        foreach (int number in index)
        {
            Console.Write("{0} ",number);
        }
        Console.WriteLine();
    }
}

