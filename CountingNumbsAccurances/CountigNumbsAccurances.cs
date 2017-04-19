namespace CountingNumbsAccurances
{
    using System;
    using System.Linq;

    public class CountigNumbsAccurances
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            numbers.Sort();
            numbers.Add(int.MaxValue); // Добавяме един последен елемент - достатъчно с голяма стойност, за да има с какво да се сравни реално последният ни елемент от листа, тъй като няма как да го принтираме според логическия код по-долу. Това си е нещо като хак, но в случая помага и работи.

            int counter = 1;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                var currentNumber = numbers[i];
                var nextNumber = numbers[i + 1];

                if (currentNumber == nextNumber)
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine($"{currentNumber} -> {counter}");
                    counter = 1;
                }
            }
        }
    }
}
