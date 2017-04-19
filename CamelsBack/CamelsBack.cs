namespace CamelsBack
{
    using System;
    using System.Linq;

    public class CamelsBack
    {
        public static void Main()
        {
            var buildings = Console.ReadLine().Split().Select(int.Parse).ToList();
            var camelBacks = int.Parse(Console.ReadLine());

            var leftRightBuildingsCount = buildings.Count - camelBacks;

            if (leftRightBuildingsCount > 0)
            {
                var oneSideCount = leftRightBuildingsCount / 2;

                for (int i = 0; i < oneSideCount; i++)
                {
                    buildings.RemoveAt(0);
                    buildings.RemoveAt(buildings.Count - 1);
                }

                Console.WriteLine("{0} rounds", oneSideCount);
                Console.WriteLine("remaining: " + string.Join(" ", buildings));
            }
            else
            {
                Console.WriteLine("already stable: " + string.Join(" ", buildings));
            }
        }
    }
}
