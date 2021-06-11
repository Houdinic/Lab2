using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Solution
    {
        public static int Result()
        {
            int max = 0;
            string res="";
            string[] inputArrary = GetArrary.Arrays();
            Dictionary<string, int> counter = new Dictionary<string, int>();
            for (int i = 0; i < inputArrary.Length; i++)
            {
                if (counter.ContainsKey(inputArrary[i]))
                {
                    counter[inputArrary[i]]++;
                    
                }
                else
                {
                    counter.Add(inputArrary[i], 1);
                }
                if (counter[inputArrary[i]] > max)
                {
                    max = counter[inputArrary[i]];
                    res = inputArrary[i];
                }
                
            }
            return Convert.ToInt32(res);
        }
    }
}
