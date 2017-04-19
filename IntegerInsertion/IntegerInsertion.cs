namespace IntegerInsertion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IntegerInsertion
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            var nextData = Console.ReadLine();

            while (nextData != "end")
            {
                int nextDataIndex = int.Parse(nextData[0].ToString());
                var nextNumber = int.Parse(nextData);
                input.Insert(nextDataIndex, nextNumber);

                nextData = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
