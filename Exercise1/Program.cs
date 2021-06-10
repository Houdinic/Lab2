using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.GetData();
            Console.WriteLine(r.GetArea());
            Console.WriteLine(r.GetPerimeter());
            Console.ReadLine();
        }
    }
}
