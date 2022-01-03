using System;
using System.Collections;
using System.Collections.Generic;

namespace hashes
{
    public class ReadonlyBytes 
    {
        int[] intArr;
        string[] strArr;

        public ReadonlyBytes(params int[] arr)
        {
            intArr = arr;
        }
        public ReadonlyBytes(params string[] arr)
        {
            strArr = arr;
        }

        public int Lenght(Array arr)
        {
            return arr.Length;
        }
    }
 
}