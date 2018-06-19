using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWith97Questions
{
    class Program:Base
    {
        static void Main(string[] args)
        {
           
            //6-7ci sualin cavabi :
            // bu suallarin class lari en asagidadi

            Console.WriteLine("6-7ci sual ucun :");
            Console.WriteLine(" ");

            //Mellim siz asagida kommente alinmis yeri uncomment etsez error verecey cunki wordpad da dediyim kimi sealed class
            //miras alinmir.

            //Bu amil atribut ve method lara da aiddir, misalcun:

            DoSome doSome = new DoSome();

            // Burda doSome. bildirende her 2 method cixacaq cunki evvelinde her 2 method 'public' access modifier ile teyin olunub

            doSome.Print01();
            doSome.Print02();
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("11-ci sual ucun :");

            //11-ci sual ucun :
            //bu class larin suallari en asagidadi


            //const int myİnt;

            //bunu uncomment edende error verecek;

            int youInt;
            //bu halda error vermiyecek;

            const int a = 45;
            //a = 54;     bunu uncomment etsez error verecek

            ForConst forConst = new ForConst(1, 2);
            forConst.Eded01 = 5;
            forConst.Eded02 = 10;

            //forConst. yazanda Eded property leri cixacaq ancaq Count prperty lericixmayacaq, ona class dan muraciet etmek lazimdir.

            Console.WriteLine("Property with const keyword : {0}", ForConst.Count01);
            Console.WriteLine("Property with const keyword : {0}", ForConst.Count02);

            Console.WriteLine(" ");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("12-ci sual ucun");

            // 12-ci sual ucun :

            ForReadonly forReadonly = new ForReadonly(1, 2);
            Console.WriteLine("call with object : {0}",forReadonly.x);
            Console.WriteLine("call with object : {0}",forReadonly.y);

            Console.WriteLine(" ");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("16-ci sual ucun :");

            int eded = 22;
            string soz = "Mirzamin";
            object obj = soz;
            try
            {
                eded = (int)obj;
                Console.WriteLine(eded);
            }
            catch (IOException ex)
            {
                throw (ex);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Cevirme prosesinde porblem yasandi");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Duzgun deyer tipleri muqayise edilmir");
            }



            Console.WriteLine(" ");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("17-ci sual ucun :");

            // 17-ci sual ucun :

            //17 ve 22-ci suallari proqrami crash etdiyi ucun comment e almisam. Her birini ayri ayriliqda uncomment edim yoxlaya bilerseiniz

            //int aa = 22;
            //string bb = "Mirzamin";
            //object obj01 = soz;
            //try
            //{
            //    aa = (int)obj01;
            //}
            //finally
            //{
            //    Console.WriteLine(" ");
            //    Console.WriteLine("Biz bu dyerleri cevire bilmedik evezinde cevirilen deyerin default unu size qaytaririq : {0}", aa);
            //}



            Console.WriteLine(" ");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine(" ");

            Console.WriteLine("22-ci sual ucun :");

            //int a1 = 21;
            //int a2 = 0;

            //try
            //{
            //    int a3 = a1 / a2;
            //}
            //finally
            //{
            //    try
            //    {
            //        int a3 = a1 / a2;
            //    }
            //    catch (Exception)
            //    {

            //        Console.WriteLine("finally metodunun sehv cixma ani");
            //    }
            //}


           
            Console.WriteLine(" ");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine(" ");


            //25-ci sual :

            Console.WriteLine("25-ci sual ucun :");

            int yash = 70;
            string _name;

            ForOutAndRef forOutAndRef = new ForOutAndRef();
            forOutAndRef.ForOut(out _name);
            Console.WriteLine("Out metodundan sonra : {0}", _name);

            Console.WriteLine("Ref metodundan evvel : {0}", yash);
            forOutAndRef.ForRef(ref yash);
            Console.WriteLine("Ref metodundan sonra : {0}", yash);


            Console.WriteLine(" ");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine(" ");

            // 26-ci saual ucun

            Console.WriteLine("26-cisual ucun :");

            ForJaggedArray.CountOfJaggedArrays();
            Console.WriteLine("ForJaggedArray class indaki arr03 array indeki array lerin yekun sayi : {0}", ForJaggedArray.arr03.Length);



            Console.WriteLine(" ");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine(" ");

            // 27-ci saual ucun

            Console.WriteLine("27-cisual ucun :");

            ForThisİnStaticMethod forThis = new ForThisİnStaticMethod();
            Console.WriteLine("ForThisİnStaticMethod class inin memberi olan ForThis() methodu mene bu class tipli obyekt qaytaracaq : ");
            forThis.ForThis();

            Console.WriteLine(" ");

            Console.WriteLine("ForThisİnStaticMethod class inin memberi olmayan ForStatic() methodu mene yene bu class tipli obyekt qaytaracaq");

            ForThisİnStaticMethod.ForStatic(forThis);



            Console.WriteLine(" ");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine(" ");

            // 31-ci saual ucun

            Console.WriteLine("31-cisual ucun :");

            // Mellim basa qayidib baxa bilersiniz Base class ini Program class ina miras almisam

            Base @base = new Base();
            Program program = new Program();
            Console.WriteLine("Before change : {0}",program.myInt);
            program.myInt = 100;
            Console.WriteLine("After change : {0}", program.myInt);



            Console.WriteLine(" ");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine(" ");

            // 31-ci saual ucun

            Console.WriteLine("31-cisual ucun :");





            Console.WriteLine(" ");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine(" ");

            // 24-cu sual :

            Console.WriteLine("24-ci sual ucun :");

            ForStatics.CountAge();


        }
    }
    public class Something : Some {

        //6-tci sual ucun:
        
        sealed public override void Print02()
        {
            Console.WriteLine("example override for sealed method");
        }
        public override void Print01()
        {
            base.Print01();
        }

    }
    public class Some
    {

        //6-7ci sual ucun:
        public const string Name = null;
        public virtual void Print01()
        {
            Console.WriteLine("26 Iyun Azerbaycan Silahli Quvveleri Gunudur");
        }
        public virtual void Print02()
        {
            Console.WriteLine("example override for sealed method");
        }
    }
    public class DoSome:Something
    {

        //6-7ci sual ucun:

        public override void Print01()
        {
            base.Print01();
        }
    }




    //sealed class Sealed
    //{

    //}

    //public class MirasAlan : Sealed
    //{
    //    //6-7-ci sual ucun:
    //}


    public class ForConst
    {
        //11-ci sual ucun :
        
        public const int Count01 = 12;
        public const int Count02 = Count01 * 13;
        public int Eded01;
        public int Eded02;

        public ForConst(int x, int y)
        {
            Eded01 = x;
            Eded02 = y;
            Console.WriteLine(Eded01+Eded02);
        }
    }
    public class ForReadonly
    {
        public readonly int x;
        public readonly int y;
        
        public ForReadonly(int a, int b)
        {
            x = a;
            y = b;
            Console.WriteLine(a+b);
        }

    }
}
