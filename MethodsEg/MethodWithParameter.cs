using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsEg
{
    class MethodWithParameter
    {
        void ByValue(string p)

        {
            p = "00000000000";
            Console.WriteLine("Value Changed Inside Method :ph{0},p");

        }

        static void Main()

        {
            string phno = "9876543214";
            MethodWithParameter mobj = new MethodWithParameter();
            Console.WriteLine("before calling byvalue method:phno:{0}", phno);
            mobj.ByValue(phno);
            Console.WriteLine("after calling byvalue method:phno:{0}", phno);
            Console.WriteLine("-------------");
            Console.WriteLine("before calling byvalue method:phno:{0}", phno);
            mobj.ByReference(ref phno);
            Console.WriteLine("after calling byvalue method:phno:{0}", phno);
            Console.Read();
        }
    }
}
