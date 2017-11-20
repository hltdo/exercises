using System;

/* You are given an array of strings. Write a method that sorts the array by the length of its 
   elements (the number of characters composing them).
 */
class SortByStringLength
{
    static void Main()
    {
        //Console.WriteLine("Enter elements separated by comma and single space: ");

        string[] sequence = 
        {
         "maraton" , "ton", "matrica", "search",
         "august", "notebook", "pen", "silver"  
        }; //Console.ReadLine(); 
        Console.WriteLine("Sorted by length:");
        Console.WriteLine(String.Join("\n",SortByLength(sequence)));   
    }
    private static string[] SortByLength(string[] sequence)
    {
        Array.Sort(sequence, (s1, s2) => s1.Length.CompareTo(s2.Length));
        return sequence;
    }
}
