namespace DistinctList
{
    using System;
    using System.Linq;

    public class DistinctList
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < input.Count; i++)
            {
                for (int j = i + 1; j < input.Count; j++)
                {
                    if (input[i] == input[j])
                    {
                        input.RemoveAt(j);
                        j--;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
