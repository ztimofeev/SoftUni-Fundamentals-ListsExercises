using System;
using System.Collections.Generic;
using System.Linq;

namespace StuckZipper
{
    public class StuckZipper
    {
        public static void Main()
        {
            var list1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var list2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var minNumberOfDigits = CalculateNumberOfDigits(list1, list2);

            RemovingNumbersWithMoreDigits(list1, minNumberOfDigits);
            RemovingNumbersWithMoreDigits(list2, minNumberOfDigits);

            var insertionIndex = 1;
            for (int i = 0; i < list1.Count; i++)
            {
                list2.Insert(Math.Min(insertionIndex, list2.Count), list1[i]);
                insertionIndex += 2;
            }

            Console.WriteLine(string.Join(" ", list2));
        }

        public static List<int> RemovingNumbersWithMoreDigits(List<int> list, int bestNumberOfDigits)
        {
            for (int i = 0; i < list.Count; i++)
            {
                var currentNumberOfDigits = CoutNumberOfDigits(list[i]);

                if (currentNumberOfDigits > bestNumberOfDigits)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }

            return list;
        }

        public static int CalculateNumberOfDigits(List<int> list1, List<int> list2)
        {
            var minNumberOfDigits = int.MaxValue;

            foreach (var number in list1)
            {
                var numberOfDigits = CoutNumberOfDigits(number);
                if (numberOfDigits < minNumberOfDigits)
                {
                    minNumberOfDigits = numberOfDigits;
                }
            }

            foreach (var number in list2)
            {
                var numberOfDigits = CoutNumberOfDigits(number);
                if (numberOfDigits < minNumberOfDigits)
                {
                    minNumberOfDigits = numberOfDigits;
                }
            }

            return minNumberOfDigits;
        }

        public static int CoutNumberOfDigits(int number)
        {
            number = Math.Abs(number);
            var numberOfDigits = number.ToString().Length;

            return numberOfDigits;
        }
    }
}
