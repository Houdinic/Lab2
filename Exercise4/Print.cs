using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class Print
    {
        public static void SprialPrint(string[,] matrix)
        {
            int rows = matrix.GetLength(0)-1;
            int cols = matrix.GetLength(1)-1;
            int rstart = 0, cstart = 0, counter=0,indicator=0,r=0,c=0;
            string cur = "";
            do
            {
                cur = matrix[r, c];//get current item
                Console.Write(cur);
                switch (indicator%4)
                {
                    case 0:
                        if (c>=cols)
                        {
                            indicator++;
                            r++;
                            rstart++;
                        }
                        else c++;
                        break;
                    case 1:
                        if (r>=rows)
                        {
                            indicator++;
                            c--;
                            cols--;
                        }
                        else r++;
                        break;
                    case 2:
                        if (c <= cstart)
                        {
                            indicator++;
                            r--;
                            rows--;
                        }
                        else c--;
                        break;
                    case 3:
                        if (r<=rstart)
                        {
                            indicator++;
                            c++;
                            cstart++;
                        }
                        else r--;
                        break;
                        
                }
                counter++;
            } while (counter<matrix.Length);


        }

    }
}
