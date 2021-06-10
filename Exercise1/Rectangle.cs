using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class Rectangle
    {
        double length = 1, width = 1;
        public void GetData()
        {
            again:
            Console.WriteLine("Enter Length");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter width");
            width = Convert.ToDouble(Console.ReadLine());
            if (length<0 || length >20 ||width <0 || width>20)
            {
                Console.WriteLine("Please enter length and width within 20");
                goto again;
            }
        }
        public double GetArea()
        {
            return length * width;
        }
        public double GetPerimeter()
        {
            return 2 * (length + width);
        }


    }
}
