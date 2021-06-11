using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of boxes you want to create:");
            int size = Convert.ToInt32(Console.ReadLine());
            Box[] boxes = new Box[size];
            for (int i = 0; i < size; i++)
            {
                Box box = new Box();
                Console.WriteLine("Enter the length for box");
                box.setLength(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Enter the height for box");
                box.setHeight(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Enter the breadth for box");
                box.setBreadth(Convert.ToDouble(Console.ReadLine()));
                boxes[i] = box;
            }
            for (int i = 0; i < boxes.Length; i++)
            {
                Console.WriteLine("Volume of Box{0} : {1}",i+1,boxes[i].getVolume());
            }
        }
    }
}
