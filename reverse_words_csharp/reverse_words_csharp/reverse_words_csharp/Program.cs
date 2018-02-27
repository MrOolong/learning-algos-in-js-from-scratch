using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_words_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseWords rv1 = new ReverseWords();
            var output = rv1.reverseWords("this is a string of words");
            Console.WriteLine(output);
        }
    }
}
