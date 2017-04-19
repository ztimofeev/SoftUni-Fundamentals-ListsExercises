namespace SumAjacentEqualNums_2verison
{
    using System;
    using System.Linq;

    public class SumAjacentEqualNums
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < numbers.Count - 1; j++)
                {
                    if (numbers[j] == numbers[j + 1])
                    {
                        numbers[j] += numbers[j + 1];
                        numbers.Remove(numbers[j + 1]);
                        j--;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
