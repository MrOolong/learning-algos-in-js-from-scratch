using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_words_csharp
{
    class ReverseWords
    {
        public string reverseWords(string input)
        {
            // split input words on space character
            string[] wordsArr = input.Split(' ');
            // c# does not allow push to arrays, so create a list string array to store the reversed words
            List<string> reverseWordsArr = new List<string> ();

            // iterate through input string and reverse words
            foreach (var word in wordsArr)
            {
                // create empty variable to store reversed string
                var reversedWord = "";
                for (var i = word.Length - 1; i >= 0; i--)
                {
                    reversedWord += word[i];
                }
                // use Add() method to add each reversed word to the list
                reverseWordsArr.Add(reversedWord);
            }

            return string.Join(" ", reverseWordsArr);
        }
    }
}
