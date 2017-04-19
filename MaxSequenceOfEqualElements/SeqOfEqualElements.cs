namespace MaxSequenceOfEqualElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SeqOfEqualElements
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var uniqs = numbers.Distinct();
            var maxCount = 1;
            var bestNumber = 0;

            foreach (var num in uniqs)
            {
                var count = numbers.Count(x => x == num);
                if (count > maxCount)
                {
                    maxCount = count;
                    bestNumber = num;
                }
            }

            List<int> result = new List<int>();
            for (int i = 0; i < maxCount; i++)
            {
                result.Add(bestNumber);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
