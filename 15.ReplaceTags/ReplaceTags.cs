﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 15. Replace tags

Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
 */

class ReplaceTags
{
    static void Main()
    {
        string input = @"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
        Console.WriteLine("Text:\n" + input + "\n");

        input = input.Replace((@"<a href="""), "[URL=");
        input = input.Replace(@""">", "]");
        input = input.Replace("</a>", "[/URL]");

        Console.WriteLine("Text with replaced tags:");
        Console.WriteLine(input);
    }
}

