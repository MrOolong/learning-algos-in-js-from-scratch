using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayInPlace
{
    class Program
    {
        static void Main(string[] args)
        {
            // add 
            ReverseArray ra1 = new ReverseArray();
            //Console.WriteLine("Enter an array of numbers delimited by commas");
            //var input = Console.ReadLine();
            //Console.WriteLine(input);
            var output = ra1.ReverseArrayMethod(new int[]{ 1,2,3,4});
            //var output = ra1.ReverseArrayMethod
            foreach(var item in output)
            {
                Console.WriteLine(output.ToString());
            }
        }
    }
}
