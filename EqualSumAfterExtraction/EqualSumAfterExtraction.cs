using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSumAfterExtraction
{
    public class EqualSumAfterExtraction
    {
        public static void Main()
        {
            var testNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var testSum = 0;

            foreach (var number in testNumbers)
            {
                testSum += number;
                if (numbers.Contains(number))
                {
                    numbers.Remove(number);
                }
            }

            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            var diff = Math.Abs(sum - testSum);

            if (diff == 0)
            {
                Console.WriteLine($"Yes. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {diff}");
            }
        }
    }
}
