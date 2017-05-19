namespace Algorithm.Palindrome.V1
{
    using System;

    public class Palindrome
    {
        public bool IsPalindrome(string word)
        {
            if (string.IsNullOrWhiteSpace(word)) throw new ArgumentNullException(nameof(word));
            if (word.Length == 1) throw new ArgumentException();
            var flag = true;
            var length = word.Length - 1;

            for (var i = length; i >= 0; i--)
            {
                if (!word[i].Equals(word[length - i]))
                {
                    flag = false;
                    break;
                }
                if (i == length - i) break;
            }

            return flag;
        }
    }
}
