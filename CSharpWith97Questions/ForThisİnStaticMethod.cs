using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWith97Questions
{
    public class ForThisİnStaticMethod
    {
        public void ForThis()
        {
            Console.WriteLine(this.ToString());
        }

        public static void ForStatic()
        {

            // 1ci usul:

            ForThisİnStaticMethod obj = new ForThisİnStaticMethod();
            Console.WriteLine(obj.ToString());
        }

        public static void ForStatic(ForThisİnStaticMethod obj)
        {

            // 2ci usul:

            Console.WriteLine(obj.ToString());
        }

        //men bu metodun icine bu class tipli deyisen oturduyume gore Prgram class inda ForThisİnStaticMethod class indan yaratdigim
        //obyekti parametr kimi static olan ForStatic() metoduna a oturduyumden mene yene ForThisİnStaticMethod class tipinde
        // bir obyekt qaytaracaq
    }
}
