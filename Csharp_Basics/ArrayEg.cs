using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics
{
    class ArrayEg
    {
        static void Main()

        {
            string[] flower = new string[4];

            flower[0] = "Lily";
            flower[1] = "Rose";
            flower[2] = "Jasmin";
            flower[3] = "Lotus";

            Console.WriteLine(flower[0]);
           

            for(int i=0; i<flower.Length;i++)

            {
                Console.WriteLine("index{0}:{1}", i, flower[i]);

            }






            Console.ReadLine();
        }
    }
}
