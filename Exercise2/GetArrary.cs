using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class GetArrary
    {
        public static string[] Arrays()
        {
            int size;
            Console.WriteLine("Enter the size of your array");
            size = Convert.ToInt32(Console.ReadLine());
            int[] res = new int[size];
            Console.WriteLine($"Please enter {size} values");
            string values = Console.ReadLine();
            return values.Split(" ");
            
        }
    }
}
