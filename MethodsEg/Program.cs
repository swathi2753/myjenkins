using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsEg
{
    class Program
    {
        void Welcome()
        {
            Console.WriteLine("Welcome all");

        }
        string GetName()

        {
            return "SRI";

        }

        int GetAge()
        {

            return 22;
        }

        static void Main()
        {

            Program egl = new Program();

            string name = egl.GetName();
            Console.WriteLine("Name:{0}", name);
            Console.WriteLine("Age:{0}", egl.GetAge());
            Console.ReadLine();
        }
    }
}

            