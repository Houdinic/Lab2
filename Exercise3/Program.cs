using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter 2 numbers and the second one must be larger than the first one");
            string[] splitted=Console.ReadLine().Split(" ");
            Solution.Result(Convert.ToInt32(splitted[0]), Convert.ToInt32(splitted[1]));
        }
    }
}
