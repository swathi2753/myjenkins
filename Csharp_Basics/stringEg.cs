using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics
{
    class stringEg
    {
        static void Main()
        {
            String Firstname = "swathi N";
            Console.WriteLine("Length of the string :{0}", Firstname.Length);
            Console.WriteLine("converting to uppercae :{0}", Firstname.ToUpper());
            Console.WriteLine("contains :{0}", Firstname.Contains("wat"));
            Console.WriteLine("Index x :{0}", Firstname.IndexOf("s"));
            Console.WriteLine("check wheather" + "first character starts with :{0}", Firstname.StartsWith("s"));
           

            Console.Read();


        }
    }
}
