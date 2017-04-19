namespace SplitByWordCasing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SplitByWordCase
    {
        public static void Main()
        {
            var separator = new char[] {',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' '};
            var sentence = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();

            foreach (var word in sentence)
            {
                if (word == word.ToLower() && IsLetters(word) == "letter")
                {
                    lowerCase.Add(word);
                }
                else if (word == word.ToUpper() && IsLetters(word) == "letter")
                {
                    upperCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
        }

        public static string IsLetters(string word)
        {
            var result = "";
            for (int i = 0; i < word.Length; i++)
            {
                if ((word[i] >= 'a' && word[i] <= 'z') || (word[i] >= 'A' && word[i] <= 'Z'))
                {
                    result = "letter";
                }
                else
                {
                    result = "symbol";
                    return result;
                }
            }
            return result;
        }
    }
}
