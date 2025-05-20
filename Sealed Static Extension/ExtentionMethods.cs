
using System.Text.RegularExpressions;

namespace Sealed_Static_Extension
{
    public static class ExtensionMethods
    {
        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;
        }
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }
        public static bool IsContainsDigit(this string input)
        {
            return input.Any(char.IsDigit);
        }
        public static string ToCapitalize(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input;

            input = input.Trim();
            return char.ToUpper(input[0]) + input.Substring(1).ToLower();
        }

        public static int[] GetValueIndexes(this string input, char c)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == c)
                    count++;
            }
            int[] indexes = new int [count];
            if (count > 0)
            {
                int index = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == c)
                        indexes[index++] = i;   
                }
            }
            return indexes;
        }

        public static string GetFirstSentence(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;
            char[] sentenceEndings = { '.', '!', '?' };
            for (int i = 0; i < input.Length; i++)
            {
                if (sentenceEndings.Contains(input[i]))
                    return input.Substring(0, i + 1).Trim();
            }
            return input.Trim();
        }
        public static string GetSecondWord(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            var words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            return words[1];
        }

        public static int MathCount(this string input,string word)
        {
            var words = input.Split(new[] { ' ', '.', ','}, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            foreach (var i in words)
            {
                if (string.Equals(i,word,StringComparison.OrdinalIgnoreCase))
                    count++;
            }
            return count;
        }

        public static bool Palindrome(this int input)
        {
            int reverse = 0;
            int number = input;
            while (number > 0)
            {
                int temp = input % 10;
                reverse = reverse * 10 + temp;
                number /= 10;
            }
            return reverse == input;
        }

        public static bool IsValidGroupNo(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;
            if (!Regex.IsMatch(input, @"^[A-Z]{1}[0-9]{3}$"))
                return false;

            return true;
        }
        public static bool CheckFullname(this string fullname)
        {
            if (string.IsNullOrWhiteSpace(fullname))
                return false;

            var names = fullname.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            return names.Length == 2;
        }

    }
     
}
