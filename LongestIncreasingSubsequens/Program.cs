namespace LongestIncreasingSubsequens
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();


            List<int> bestList = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                var currentList = GetSubList(input, i);

                if (currentList.Count > bestList.Count)
                {

                    bestList = currentList;

                }
            }

            Console.WriteLine(string.Join(" ", bestList));
        }

        public static List<int> GetSubList(List<int> input, int startIndex)
        {
            List<int> output = new List<int>();

            output.Add(input[startIndex]);

            
            var min = output[output.Count - 1];
            
            
            for (int i = startIndex; i < input.Count; i++)
            {
                var nextMin = input.Max();

                for (int j = startIndex + 1; j < input.Count; j++)
                {
                    var current = input[j];
                    if ((current > min) && (current < nextMin))
                    {
                        nextMin = current;
                    }
                }
                if (!output.Contains(nextMin))
                {
                    output.Add(nextMin);
                }
                
                input.Remove(nextMin);
            }


            return output;
        }
    }
}
