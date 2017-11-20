using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 11. Format number

Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
Format the output aligned right in 15 symbols.
 */

class FormatNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        string decimalNumber = number.ToString("F2");
        Console.WriteLine("Decimal number:\n{0, 15}\n", decimalNumber);
        string hexadec = number.ToString("X");
        Console.WriteLine("Hexadecimal number:\n{0, 15}\n", hexadec);
        string percentage = (number/100d).ToString("P");
        Console.WriteLine("Number as a percentage:\n{0,15}\n", percentage);
        string scientificNotation = number.ToString("E");
        Console.WriteLine("Number as a scientific notation:\n{0,15}\n", scientificNotation);
    }
}

