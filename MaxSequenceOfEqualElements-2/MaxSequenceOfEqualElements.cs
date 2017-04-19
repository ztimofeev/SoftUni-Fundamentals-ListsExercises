namespace MaxSequenceOfEqualElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            var maxCount = 1;
            var currentCounter = 1;
            var bestValue = nums[0];

            for (int i = 0; i < nums.Count - 1; i++)
            {

                if (nums[i] == nums[i + 1])
                {
                    currentCounter++;
                    if (currentCounter > maxCount)
                    {
                        maxCount = currentCounter;
                        bestValue = nums[i];
                    }
                }
                else
                {
                    currentCounter = 1;
                }
            }

            List<int> result = new List<int>();
            for (int i = 0; i < maxCount; i++)
            {
                result.Add(bestValue); 
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
