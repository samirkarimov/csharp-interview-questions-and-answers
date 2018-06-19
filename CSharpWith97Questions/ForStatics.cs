using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWith97Questions
{
    static class ForStatics
    {
        public static int BornAge;
        public static int ThisYear;
        public static void CountAge()
        {
            Console.WriteLine("Doguldugunuz ili daxil edin :");
            BornAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hazirki ili daxil edin :");
            ThisYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sizin yashiniz : {0}", (ThisYear-BornAge));
        }
    }
}
