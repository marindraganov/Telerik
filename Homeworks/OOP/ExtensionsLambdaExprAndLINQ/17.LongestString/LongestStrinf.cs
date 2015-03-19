namespace _17.LongestString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class LongestStrinf
    {
        static void Main()
        {
            List<string> listOfStrings = new List<string> { "1", "rogozka", "hip hopa mii", "abc123", "Traktor" };

            var longest = listOfStrings.Where(s => s.Length == listOfStrings.Max(m => m.Length)).First();

            Console.WriteLine("\"{0}\"",longest);
        }
    }
}
