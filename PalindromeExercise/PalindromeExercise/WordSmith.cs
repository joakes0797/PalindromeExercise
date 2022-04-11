using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            
            string newWord = "";
            foreach (char c in charArray)
            {
                newWord += c;
            }

            if (word.ToLower() == newWord.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
