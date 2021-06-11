using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Solution
    {
        
        public static void Result(int A, int B)
        {
            Console.WriteLine(Math.Floor(Math.Sqrt(B)) - Math.Ceiling(Math.Sqrt(A)) + 1); 

        }
    }
}
