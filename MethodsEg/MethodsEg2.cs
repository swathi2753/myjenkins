using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsEg
{
    class MethodsEg2
    {

        void DisplayingUserDetails(string cn, string ci, string g, string mail)
        {

            Console.WriteLine("Name:{0}||city:{1}||gender:{2}||email:{3}", cn, ci, g, mail);


        }
        int Total(int[] marray)
        {
            int sum = 0;
            for (int i = 0; i < marray.Length; i++)

            {
                sum = sum + marray[i];

            }

            return sum;

        }

        static void Main()
        {
            string Cname, City, gender, email;
            int[] mark = new int[3](5, 6, 7);
            Console.WriteLine("Enter Cname");
            Cname = Console.ReadLine();
            Console.WriteLine("Enter City");
            City = Console.ReadLine();
            Console.WriteLine("Enter gender");
            gender = Console.ReadLine();
            Console.WriteLine("Enter email");
            email = Console.ReadLine();

            MethodsEg2 eg2 = new MethodsEg2();
            eg2.DisplayingUserDetails(Cname, City, gender, email);
            Console.WriteLine("Sum of Marks is: {0}", eg2.Total(mark));
            Console.Read();
        }

    }


}
