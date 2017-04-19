namespace MatrixOfLetters
{
    using System;

    public class MtrixOfLetters
    {
        public static void Main()
        {
            var rows = int.Parse(Console.ReadLine());
            var cols = int.Parse(Console.ReadLine());
            var counter = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write((char) (counter + 'A') + " ");
                    counter++;
                }
                Console.WriteLine();
            }
        }
    }
}
