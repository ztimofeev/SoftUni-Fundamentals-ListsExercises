using System;
using System.Collections.Generic;
using System.Linq;

namespace TrackDownloader
{
    public class TrackDownloader
    {
        public static void Main()
        {
            var blacklist = Console.ReadLine().Split().ToList();

            var result = new List<string>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                bool isInBlacklist = false;

                foreach (var name in blacklist)
                {
                    if (input.Contains(name))
                    {
                        isInBlacklist = true;
                        break;
                    }
                }

                if (!isInBlacklist)
                {
                    result.Add(input);
                }

                input = Console.ReadLine();
            }

            result.Sort();

            foreach (var track in result)
            {
                Console.WriteLine(track);
            }
        }
    }
}
