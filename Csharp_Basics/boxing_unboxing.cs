using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics
{
    class boxing_unboxing
    {
        static void Main()
        {
            int petrol = 100;
            object o = petrol;
            Console.WriteLine("boxing converting value type to reference type:{0}", petrol);

            string oil = "10";
            int oilprice = Convert.ToInt32(oil);
            Console.WriteLine("ReferenceEquals type to value type" + "-unboxing:{0}", oilprice);
            Console.Read();
        }
    }
}
