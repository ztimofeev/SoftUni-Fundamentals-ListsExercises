using System;
using System.Linq;

namespace SumAjacentEqualNums_3
{
    public class SunAjacentEqualNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i - 1] == numbers[i])
                {
                    numbers[i - 1] *= 2;
                    numbers.RemoveAt(i);
                    if (i < 2)
                    {
                        i--;
                    }
                    else
                    {
                        i = i - 2;
                    }
                    // It will working even we say i = 0; and every time to start from the begining but it will be much slower.
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
