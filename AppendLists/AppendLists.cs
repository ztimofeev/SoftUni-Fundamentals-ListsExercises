namespace AppendLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AppendLists
    {
        public static void Main()
        {
            var line = Console.ReadLine().Split('|').ToList();
           
            List<string> results = new List<string>();

            for (int i = line.Count - 1; i >= 0; i--)
            {
                var current = line[i].Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                results.Add(string.Join(" ", current));
            }
            Console.WriteLine(string.Join(" ", results));
        }
    }
}
