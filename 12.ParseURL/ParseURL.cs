using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 12. Parse URL

Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.

Example:

URL	                                                    Information
http://telerikacademy.com/Courses/Courses/Details/212	[protocol] = http 
                                                        [server] = telerikacademy.com 
                                                        [resource] = /Courses/Courses/Details/212
 */

class ParseURL
{
    static void Main()
    {
        //Console.WriteLine("Enter URL: ");
        string url = "http://telerikacademy.com/Courses/Courses/Details/212"; //Console.ReadLine();
        
        Uri uri = new Uri(url);

        Console.WriteLine("[protocol] = {0} ", uri.Scheme);
        Console.WriteLine("[server] = {0}",uri.Host);
        Console.WriteLine("[resource] = {0}",uri.AbsolutePath);
    }
}

