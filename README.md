# C# Müsahibə sualları və cavabları

1. C# nədir? 


> C# multi paradiqmalı proqramlaşdırma dilidir.Özündə imperative,deklarativ,functional,generic,OOP paradiqmaları cəmləşdirir.






2. C# - ın özəlliklərini İzah Edin?

> .C# funksiyaları bunlardır:
1)Sadədir.Bu o deməkdir ki,problemə strukturlu yanaşər(problem bir neçə hissəyə bölür)həmçibin library funksiyalarının,data types və s. funksiyalarının genişliyi ilə fərqlənir.
2)Müasir proqramlaşdırma dilidir. C# müasir tələblər əsasında yaranıb.
3)OOP dildir.Yeni ki biz c#da her weyi obyekt kimi goruruk,obyektler ise klasslarin ekzemplaridir,klasslar ise inheritance iyerarxiyasi yaradirlar.
4)Tehlukesizdir.Bu o demkdir ki,yazdigimiz kod ancaq gedib yaddawa cata biler,bu ise yazdigimiz proqramin tehlukesizliyini gosterir
5)interoperability-совместимость(azerbaycanca bilmedim ne yazim).Bu prosess o demekdir ki,c++ applicationun  elediyi  butun iwleri c# programalri da ede bilir.
6)updatable.Avtomatik olaraq c# yeni versiyasi cixanda yenilenir,neticede kohne fayllar silinir ve yenisiyle evez olunur.
7)Compoent oriented dildir
8)structured dildir.Yeni ki,programi muxtelif hisselere functionlarla bolub onu deyiwe bilerik
9)rich library.Choxlu funksiyalardan ibaretdir
10)suret.Compilasiya vaxti suretlidir



  
  
 
3. C#-ın üstünlüklərindən ən vaciblərini sadalayın.
> C#-in ustunlukleri bunlardir:
Proqramlawdirmaya component-oriented yanawma.
Eventleri obrabotat elemek bacarigi.Misalchun try-catch keyword)
Indexer-index operatorlaridir,konteyner klassinin elementlerine muraciet etmekchun istifade olunur
Foreach operatorunun olmagi
Boxing ve unboxing mexanizminin olmagi


4. What are IDE’s provided by Microsoft for C# development?

> Visual Studio 2017

5. C# - daki Kamentariya Tiplərini İzah Edin

2 cur comment tipleri var:
1)//-bu yalniz bir setr kodu commentlemek ucun istifade olunur
2)/*…..*/ bu ise mueyyen istediyimiz setrler arasini kommentlemek ucun istifade olunur.


6. C# - daki Sealed Klasını İzah Edin?

> eger classimizin bawqa bir klassa inheritance vrmemeyini isteyirikse,klassimiza sealed modifikatorunu veririk.Demeli,sealed classlar inheritance ala bilirler,amma vere bilmirler.


7. Give an example of using sealed class in C#?
> Sealed classina example:
using System;
class Class1
{
    static void Main(string[] args)
    {
        SealedClass sealedCls = new SealedClass();
        int total = sealedCls.Add(4, 5);
        Console.WriteLine("Total = " + total.ToString());
    }
}
// Sealed class
sealed class SealedClass
{
    public int Add(int x, int y)
    {
        return x + y;
    }
}  

8. List out the differences between Array and ArrayList in C#?
> Array:
*Yalniz mueyyen(ona biz terefden verilmiw) tip elementleri
*Arrayde mueyyen miqdarda elementler olur,  Initialize zamani onun ramerini qeyd etmeliyik.
*Static helper class Array istifade etmekle array uzerinde,
Muxtelif tasklar icra ede bilerik.


Arraylist:
*Istenilen tip elementleri saxlayabilir
* Rzmr vermeye ehtiyac yoxdu,
                                                                                                                              Ozu avto boyuyur
*Arraylistin ozunun utilitileri var,Taskler uchun.
9. C# da "using" nə üçün istifadə olunur
10. Explain namespaces in C#?
11. Why to use keyword “const” in C#? Give an example.

> Fərz edək ki Bir dəyişənimiz var  və biz bu dəyişənimizin dəyərinin heç bir yerdə dəyişilməməsini sabit qalmasını istəyə bilərik.Bu     zaman Bize (const) - keyvordu komək edir. Const keyvordunun Qaydaları.
> 1. Const keyüordu local Dəyişənlərə və Filed-lərə Təyin Edilə Bilər.
> 2. Const keyüordu yalnız primitiv dəyərlərə təyin edilə bilər(int double).
> 3. Constant təyin etdiyimiz (field ve dəyişənlərə) declaration anında dəyər təyin etməliyik.
> 4. Constant dəyişənlər (const) - keyüordu ilə təyin edilir.

12. What is the difference between “constant” and “readonly” variables in C#?
13. Explain “static” keyword in C#?
14. What is the difference between “dispose” and “finalize” variables in C#?
15. How the exception handling is done in C#?
16. Can we execute multiple catch blocks in C#?
17. Why to use “finally” block in C#?
18. What is the difference between “finalize” and “finally” methods in C#?
19. What is the difference between “throw ex” and “throw” methods in C#?
20. Can we have only “try” block without “catch” block in C#?
21. List out two different types of errors in C#?
22. Do we get error while executing “finally” block in C#?
23. Mention the assembly name where System namespace lies in C#?
24. What are the differences between static, public and void in C#?
25. What is the difference between “out” and “ref” parameters in C#?
26. Explain Jagged Arrays in C#?
27. Can we use “this” inside a static method in C#?
28. What are value types in C#? C#-da deyer tipleri nedir ne demekdir? 
30. What are reference types in C#?
31. Can we override private virtual method in C#?
32. Explain access modifier – “protected internal” in C#?
33. In try block if we add return statement whether finally block is executed in C#?
34. What you mean by inner exception in C#?
35. C# da String Builder klasın izah edin.
36. What is the difference between “StringBuilder” and “String” in C#?
37. What is the difference between methods – “System.Array.Clone()” and “System.Array.CopyTo()” in C#?
38. Can you store multiple data types in an array?
39. How we can sort the array elements in descending order in C#?
40. Explain circular reference in C#?
41. List out some of the exceptions in C#?
42. Explain Generics in C#?
43. Explain object pool in C#?
44. What you mean by delegate in C#?
45. What are the types of delegates in C#?
46. What are the three types of Generic delegates in C#?
47. What are the differences between events and delegates in C#?
48. Can we use delegates for asynchronous method calls in C#?
49. What are the uses of delegates in C#?
50. What is Nullable Types in C#?
51. Why to use “Nullable Coalescing Operator” (??) in C#?
52. What is the difference between “as” and “is” operators in C#?
53. What is the difference between CType and Directcast in C#?
54. Is C# code is unmanaged or managed code?
55. Why to use lock statement in C#?
56. Explain Hashtable in C#?
57. How to check whether hash table contains specific key in C#?
58. What is enum in C#?
59. Which are the loop types available in C#?
60. What is the difference between “continue” and “break” statements in C#?
61. Write a sample code to write the contents to text file in C#?
62. What you mean by boxing and unboxing in C#?
63. Explain Partial Class in C#?
64. Explain Anonymous type in C#?
65. Name the compiler of C#?
66. Explain the types of unit test cases?
67. Explain Copy constructor in C#?
68. Explain Static constructor in C#?
69. Which string method is used for concatenation of two strings in c#?
70. Explain Indexers in C#?
71. What are the collection types can be used in C#?
72. Explain Attributes in C#?
73. List out the pre defined attributes in C#?
74. What is Thread in C#?
75. List out the states of a thread in C#?
76. Explain the methods and properties of Thread class in C#?
77. What is a class ?
78. What is an Object?
79. What are the Access Modifiers in C# ?
80. Explain Static Members in C# ?
81. What is Reference Type in C# ?
82. Define Property in C# ?
83. Explain Overloading in C# ?
84. What is Constructor Overloading in C# .net ?
85. What is Function Overloading in C# .net ?
86. What is Operator Overloading in C# .net ?
87. What is Data Encapsulation ?
88. Explain Inheritance in C# ?
89. Can Multiple Inheritance implemented in C# ?
90. What is Polymorphism in C# ?
91. Explain the use of Virtual Keyword in C# ?
92. What is overriding in c# ?

> Override miras yolu ilə təməl sinifin referansını istifadə edərək fərqli siniflərə aid metodları çağırmağımıza icazə verən bir xüsusiyyətdir.C# - bizə (override) əməliyyatını həyata keçirmək üçün 2 keyüord verir. (virtual və override).
Bir Metod yalnız (virtual) keyvordu ilə təyin olundugu halda biz miras alınmış sinifdə onu (override) - edə bilərik.(override) base clasda olan virtual metodu (override) - edir. Override Ozəlliyi Programçılara Təməl Sinifdə (virtual) memberi miras almış sinifdə yenidən tətbiq etməyə icazə verir. Override miras alan sinifdə dəyişilməyə ehtiyyacı olan (metod property indexer və ya event) - lər ilə işlənə bilər. override xüsusiyyəti C# - da polymoprhism qavramını tətbiq etmək üçün dizayn edilmişdir.

93. What is Method Hiding in C# 

> Derived Sinif İçərisində təməl(base) Sinifə aid bir metodu (override) etmeden təkrar Tanimlasanız base(temel) sinifdəki halı qorunacaqdır. Bu Hala Metod Hiding Deyilir.

    class Product

    {

        public int İd { get; set; }

        public string Name { get; set; }

 

        public void Test()

        {

            Console.WriteLine("Product Sinifinin Memberiyəm");

        }

    }
    
    
    
    
    class Book : Product

    {

        public string Author { get; set; }

 

        public void Test()

        {

            Console.WriteLine("Kitab Sinfinin Memberiyəm");

        }

    }


> Burada Book Sinifinde Olan Test() Metodu  Temel Product Sinifinde Olan Test() Metodu İle Eynidir Buna Gore  Base Sinifdə Olan Test()     Metodu  Gizlenir ve Book - da Olan Metod İşləyir ama Compiler Bizə Xeberdarlıq Verir. Buna Görədə Metod hiding Eederek Bu xeberdarlıqı   Aradan Qaldırırıq. nev keyvordu istifade ederek yoxlayaq.
 
      
    class Book : Product

    {

        public string Author { get; set; }

 

        //new public void Test() şeklinde de yazabiliriz.

        public new void Test()

        {

            Console.WriteLine("Kitab Sinifinin Memberiyem");

        }

    }
    
Bele Daha Düzgündür Artıq Base(təməl) Sinifdəki Metod Gizləndi. 

94. What is Abstract Class in C#?

> Abstract Siniflər .NET Tərəfindən təmin edilən təməl davranışlardan biridir. Ümumi olaraq yalnız təməl Sinifləri təmsil edən və hər hansı birinin bu Siniflərdən Obyekt yaratmasını istəmədiyimiz siniflər yaratmaq istəyə bilərsiz. c# - da (abstract) istifade ederek Astract Sinifləri Tətbiq edə Bilərik. Abstrackt sinifin mənası bu sinif - də obyekt yaradıla bilməz ama miras alına bilər.

    abstract class absClass
    {
     
    }

> Abstract Sinif (abstract) olan və (abstract) olmayan metodlar saxlaya bilər. Abstract memberlərin (abstract) sinif içərisində heç bir tətbiqi olmur ama ondan miras alan sinifə bu özəlli təmin edilir.


         abstract class absClass
         {
             public abstract void absMethod();
         }

> Dediyimiz kimi Abstract Siniflərin İçərisində abstract olmayan memberlər - də ola bilər.

    public void Show()
    {
       
    }

> Abstract metod və Abstract Sinif-dən başqa heç bir yerdə təyin edilə bilməzlər. Abstract metodlar derive olundğu sinif-də (override) olunmalıdırlar. Abstract metodların (body) - si Olmur.

> Abstract- da Bəzi Qaydalar

> 1.Abstract Sinif (selaed) - olaraq təyin edilə bilməz
> 2.Abstract metodlar yalnız abstract sinifdə ola bilər
> 3. Abstract metodlar private ola bilməz
> 4.Abstract Sinifin (Access Modifieri) həm Abstract Sinifdə həmdə ondan miras almış sinifdədə eyni olmalıdır
> 5.Abstract metodun (virtual) keyvordu olmur. Çünki Abstract metod onsuzda virtual olur.

95. What is Sealed Classes in c# ?

> Sealed Siniflər Obyekt Yönümlü Programlaşdırmanın inheritance(miras) xüsusiyyətini ləğv eiliyir. Sealed Sinifinin İxtira olunmasının məqsədi odur ki biz bu sinifə deyirkki sənin genişləndirlməyə Ehtiyyacın Yoxdur. Sən miras ala Bilməzsən

96. What is an Interface in C# ?
97. What is a Constructor in C# ?

> Qurucular Xüsusi Metodlardır və Sinifdən örnəy(abyekt) yaratdıgımız anda işə düşürlər.Qurucuların Əsas Məqsədi Sinifin Örnəyi Yaranan Anda Sinifdə Olan (private) gizli field-lari Başlatmaqdır. Əgər Biz Özümüz Qurucu Metod Yazmasaq (Compiler) Avtomatik Olaraq Default Qurucu Metodu İşə Salacaq. Default(varsayılan) qurucular Sinfidəki (numerik) field-lərə  zero(0) (string və object) - filed-lərə isə (null) - dəyəri Təyin Edir.  Qurucularda Bəzi Vacib Nöqtələr Vardır.

> 1.Sinifin Birdən Çox Qurucu Metodu Ola Bilər
> 2.Bir Qurucu Metodun Hansısa (return) Tipi Yoxdur (void) - də Daxil Olmaqla. Çünkü Obyekt return Edir.
> 3.Statik Qurucular Parameter Qəbul Edə Bilməzlər.
> 4.Bir Sinif İçərisində Yalnız Bir Statik Qurucu Ola Bilər.

> Qurucular 5 Tipə Bölünür.

> 1.Default(varsayılan) Qurucular
> 2.Parametreli Qurucular
> 3.Copy Qurucular
> 4.Statik Qurucular
> 5.Private Qurucular

> 1.1)Hər Hansı Bir Parametresi Olmayan Qurucular varsayılan(defult) qurucular adlanır.bu cür qurucuların parametresi olmur.Bunun mənfi cəhəti odur ki default(varsayılan) qurucu hər obyekt yarananda eyni dəyərlər Təyin Edir.
Hər Obyekt Yaradanda Ferqli Deyerler Teyin Etmek Mümkün Deyil. Varsayılan Qurucu Aşagıdakı Dəyərləri Təyin Edir

 1.Bütün Numerik Filedlər-ə (0) - ı
 2.Bütün (string ve object) dəyərlərə (null) - u
 
> 2.2)Ən az Bir Parametresi Olan Qurucuya Parametreli Qurucu Deyilir. Parametreli Qurucunun Müsbət Cəhəti Odur ki Hər obyekt yaradanda fərqli dəyərlər Təyin Ede Bilərsiz.

    public class Employee 
    {
       public int a,b;
       
       public Employee(int x , int y)
       {
         this.a = x;
         this.b = y;
       }
    }
    
> 3.3)Başqa bir obyektden dəyişənləri kopyalayaraq bir obyekt yaradan qurucuya (copy) qurucu deyilir.(Copy) qurucunun Əsas Məqsədi         Mövcud Olan Obektin Dəyərləri ilə Yeni Obyekt Yaratmaqdır.  
  
  > 1.Statik Qurucuların Parameteri və Access Modifieri Olmur
  > 2.Statik qurucu işə düşdüyündə istifadeci onu idarə edə bilməz
  
  
  
  

   
     public class Employee 
    {
       public string Name
       public int Age
       
       public Employee(Employee emp)
       {
         this.Name = emp.Name;
         this.Age = emp.Age;
       }
    }
    
    
> 4.4)Qurucu Statik olaraq təyin olunarsa  Bütün Obyektlər Üçün Bir dəfə Çağırılır və Sinifin ilk Obyekti Yaradilan Anda işə düşür         Statik Bir Qurucu Sinifin Statik Olan Üzvlərini Başlatmaq və Sadəcə Bir dəfə run olunacaq kodu İşə salmaq üçün İstifade Olunur.

98. What is a Destructor in C# ? 
99. What is CLR in c# ?
100. What is Garbage Collecter in C#?
