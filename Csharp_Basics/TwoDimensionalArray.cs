﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics
{
    class TwoDimensionalArray
    {
        static void Main()

        {
            Console.WriteLine("Enter rows");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter column");
            int column= Convert.ToInt32(Console.ReadLine());

            int[,] Matrix = new int [row,column ];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)

                {
                    Console.WriteLine("Enter[{0}{1}]", i, j);
                    Matrix[i,j] = Convert.ToInt32(Console.ReadLine());

                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Console.Write(Matrix[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}