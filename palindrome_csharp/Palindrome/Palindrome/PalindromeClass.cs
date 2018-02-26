using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class PalindromeClass
    {
        public void IsPalindrome(string inputText)
        {
            string input = inputText.ToLower();
            var characterArr = input.Split();
            var validCharacters = "abcdefghijklmnopqrstuvwxyz".Split();

            char[] lettersArr;
            foreach (char char1 in characterArr)
            {
                if (validCharacters.IndexOf(char1) > -1)
                
                    lettersArr.Push(char1);
                
            }
        }
    }
}
