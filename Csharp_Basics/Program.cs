using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics
{
    class Program
    {
        static void Main()

        {
            int salary = 20000;
            float f = salary;
            double d = f;
            Console.WriteLine("int:{0}||float:{1}||double:{2})", salary, f, d);
            Console.WriteLine("-----------");


            float sal = 30000.78f;
            int i = Convert.ToInt32(sal);
            Console.WriteLine("Explicit Function");
            Console.WriteLine("float to int:{0}", i);
            Console.Read();

        }
        
        }
    }

