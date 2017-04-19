namespace TearListInHalf
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TearListInHalf
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var firstSubList = new List<int>();
            var secondSubList = new List<int>();
            var result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i < numbers.Count / 2)
                {
                    secondSubList.Add(numbers[i]);
                }
                else
                {
                    firstSubList.Add(numbers[i]);
                }
            }

            for (int i = 0; i < secondSubList.Count; i++)
            {
                var tearedNumber = TearNumber(firstSubList[i]);
                result.Add(tearedNumber[0]);
                result.Add(secondSubList[i]);
                result.Add(tearedNumber[1]);
            }

            Console.WriteLine(string.Join(" ", result));
        }

        private static List<int> TearNumber(int input)
        {
            var output = new List<int>();
            output.Add(input / 10);
            output.Add(input % 10);

            return output;
        }
    }
}
