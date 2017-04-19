using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveElementsAtOddPositions
{
    public class RemoveElementsAtOddPositions
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split(' ').ToList();

            List<string> result = new List<string>();

            for (int i = 0; i < words.Count; i++)
            {
                if (i % 2 != 0)
                {
                    result.Add(words[i]);
                }
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
