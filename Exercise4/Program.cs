using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] matrix = Matrix.GetMatrix();
            
            Print.NormalPrint(matrix);

            Print.SprialPrint(matrix);
        }
    }
}
