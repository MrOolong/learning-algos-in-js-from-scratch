using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz_csharp
{
    class fizzBuzz
    {
        public void FizzBuzz(int inputNum)
        {
            for (var i = 1; i <= inputNum; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else Console.WriteLine(i);
            }
        }
    }
}
