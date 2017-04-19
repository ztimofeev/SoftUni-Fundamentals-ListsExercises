namespace FlipLIstSides
{
    using System;
    using System.Linq;

    public class FlipListSides
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 1; i < numbers.Count / 2; i++)
            {
                var temp = numbers[numbers.Count - i - 1];
                numbers[numbers.Count - i - 1] = numbers[i];
                numbers[i] = temp;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
