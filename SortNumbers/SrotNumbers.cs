namespace SortNumbers
{
    using System;
    using System.Linq;

    public class SrotNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            numbers.Sort();

            for (var i = 0; i < numbers.Count; i++)
            {
                if (i < numbers.Count - 1)
                {
                    Console.Write($"{numbers[i]} <= ");
                }
                else
                {
                    Console.Write(numbers[i]);
                }
            }
        }
    }
}
