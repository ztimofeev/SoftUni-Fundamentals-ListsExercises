namespace UnunionLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UnunionLists
    {
        public static void Main()
        {
            var primal = Console.ReadLine().Split().Select(int.Parse).ToList();
            var num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                var current = Console.ReadLine().Split().Select(int.Parse).ToList();

                List<int> ignorList = new List<int>();

                foreach (var item in current)
                {
                    if (!primal.Contains(item))
                    {
                        primal.Add(item);
                        ignorList.Add(item);
                    }
                }

                foreach (var item in ignorList)
                {
                    current.Remove(item);
                }

                foreach (var item in current)
                {
                    for (int j = 0; j < primal.Count; j++)
                    {
                        if (item == primal[j])
                        {
                            primal.RemoveAt(j);
                            j--;
                        }
                    }
                }
            }

            primal.Sort();
            Console.WriteLine(string.Join(" ", primal));
        }
    }
}
