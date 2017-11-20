using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;


/*Problem 16. Date difference

Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

Example:

Enter the first date: 27.02.2006
Enter the second date: 3.03.2006
Distance: 4 days
 */

class DatesDifference
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        //Console.WriteLine("Enter the first date in format: dd.mm.yyyy");
        string dateStr = "20.02.2015"; //Console.ReadLine();
        DateTime startDate = DateTime.ParseExact(dateStr, "d.M.yyyy", CultureInfo.InvariantCulture);

        //Console.WriteLine("Enter the second date in format: dd.mm.yyyy");
        string dateStr2 = "05.01.2016"; //Console.ReadLine();
        DateTime endDate = DateTime.ParseExact(dateStr2, "d.M.yyyy", CultureInfo.InvariantCulture);

        string startD = startDate.ToString("d/M/yyyy");
        string endD = endDate.ToString("d/M/yyyy");
        double difference = (endDate - startDate).TotalDays;

        Console.WriteLine("Difference between dates: {0} days.",Math.Abs(difference));
       
    }
}

