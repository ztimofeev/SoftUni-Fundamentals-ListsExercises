using System;
using System.Collections.Generic;
using System.Linq;

namespace StuckZipper
{
    public class Program
    {
        public static void Main()
        {
            var list1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var list2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var minNumberOfDigits = CalculateNumberOfDigits(list1, list2);

            for (int i = 0; i < list1.Count; i++)
            {
                var currentNumberOfDigits = CoutNumberOfDigits(list1[i]);

                if (currentNumberOfDigits > minNumberOfDigits)
                {
                    list1.RemoveAt(i);
                    i--;
                }
            }

            for (int i = 0; i < list2.Count; i++)
            {
                var currentNumberOfDigits = CoutNumberOfDigits(list2[i]);

                if (currentNumberOfDigits > minNumberOfDigits)
                {
                    list2.RemoveAt(i);
                    i--;
                }
            }
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
