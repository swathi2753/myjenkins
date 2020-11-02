using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics
{

    enum Feedback

    {

        poor=1,fair,good,excellent
    }
    class enumerationeg
    {
        enum months
        {

            jan, Feb, March, April, May, June, July, August, September
        }

        static void Main()

        {

            string name = "swathi";

            Console.WriteLine("Name:{0}||feedback:{1}", name, Feedback.good);

            Console.WriteLine("Name:{0}||feedback:{1}", name, (int)Feedback.good);

            Console.WriteLine("Name:{0}||feedback:{1}", name, Convert.ToInt32(Feedback.good));

            Console.Read();
        }
    }


}
