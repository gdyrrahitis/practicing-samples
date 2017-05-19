namespace Algorithm.Palindrome.V2
{
    public class Palindrome
    {
        private const int Start = -1;

        public bool IsPalindrome(string word)
        {
            var left = Start;
            var right = word.Length;

            while (right > left)
                if (AreCharactersNotEqual(word, ref left, ref right))
                    return false;

            return true;
        }

        private static bool AreCharactersNotEqual(string word, ref int left, ref int right)
        {
            return !word[++left].Equals(word[--right]);
        }
    }
}