using System;

namespace Palindrome
{
    public class NewPalindrome
    {
        public bool checkString(string word)
        {
            int end = word.Length - 1;
            int start = 0;
            while (start <= end)
            {
                if (word[start] != word[end])
                {
                    return false;
                }
                // Console.WriteLine(word[end]);
                start++;
                end--;
            }
            return true;
        }
    }
}
