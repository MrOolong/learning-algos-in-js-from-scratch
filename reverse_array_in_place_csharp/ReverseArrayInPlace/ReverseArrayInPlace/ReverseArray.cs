using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayInPlace
{
    class ReverseArray
    {
        public Array ReverseArrayMethod(int [] arr)
        {
            for (var i = 0; i < arr.Length / 2; i++)
            {
                var tempVar = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = tempVar;
            }
            return arr;
        }
    }
}
