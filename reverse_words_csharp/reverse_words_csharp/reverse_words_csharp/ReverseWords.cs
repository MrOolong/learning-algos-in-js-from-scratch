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
            string[] wordsArr = input.Split(' ');
            List<string> reverseWordsArr = new List<string> ();

            foreach (var word in wordsArr)
            {
                var reversedWord = "";
                for (var i = word.Length - 1; i >= 0; i--)
                {
                    reversedWord += word[i];
                }
                reverseWordsArr.Add(reversedWord);
            }

            return string.Join(" ", reverseWordsArr);
        }
    }
}
