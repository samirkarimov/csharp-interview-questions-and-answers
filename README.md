# Top-100-csharp-interview-question
Top 100 C# Interview Questions
1. What's  C# ? 
1. C# nədir? 
> C# , 2000ci ildə Microsoft tərəfindən yaradılan və inkişaf etdirilən, formalaşdırılması və inkişafında  rəhbərliyini Anders Hejlberg-in etdiyi, .Net Framework platformasinda çalışan ,öyrənilməsi sadə, müasir, ümumi məqsədlər üçün  yaradılmış, qrup şəklində çalışmaq üçün uyğun olan, tamamilə obyekt yönümlü proqramlaşdırma dilidir.

2. Explain the features of C#?
2. C# -ın bəzi xüsusiyyətlərini izah edin.
> construktur, parametr ötürülməsi, özəlliklər, əsas metod, XML sənədləri vəs.

3. List some of the advantages of C#?
3. C#-ın bəzi üstünlüklərini sadalayın.
> C# , obyekt yönümlü proqramlaşdırma dili olub aşağıdakı bir neçə xüsusiyyətləri vardır:
1-Sadədir-yəni həm  yazılma sintaksı insan dilinə daha  yaxın olduğu üçün hamı tərəfindən də başadüşüləndir, həm də obyekt yönümlü olduğu üçün real həyatdan olan istənilən bir prosesə uyğunlaşdırmaq mümkündür.
2-Müasir proqramlaşdırma dilidir-yəni digər böyük dillərdən , məsələn,  C, C++, Java dillərindən sonra yarandığı üçün onlarda olan bütün müsbət və mənfi  xüsusiyyətlər nəzərə alınaraq daha böyük və çətin proyektlərin həll olunması məqsədilə ideal bir proqramlaşdırma dili yaratmaq üçün formalaşdırılmışdır.
3-Obyekt yönümlü dildir-yəni real həyatdan gördüyümüz bütün hadisələri, problemləri və prosesləri proqramlaşdırma dilinə çevirərək daha asan və sürətli həll olunması mümkündür.
4-inkişaf etdirilən və daima yenilənən dildir.
5-zəngin kitabxanaya sahib bir dildir.
6-proqramın compiler və runtime zamanı daha sürətlidir.
7-Microsoft kimi böyük firma tərəfindən dəstəklənir, inkişaf etdirilir və .Net platformasının bir hissəsidir. 
8-Açıq qaynaq tipli dildir,  buna görə də geniş qaynaq tapmaq imkanına sahibdir.

4. What are IDE’s provided by Microsoft for C# development?
4. C#-ın inkişaf etdirilməsi üçün Microsoft hansı inteqrasiya etmək üsullarını təklif edir?
> Visual Studio Express (VCE) , Visual Studio (VS), Visual Web Developer

5. Explain the types of comments in C#?
5. C# -ın kommentariya növlərini izah edin.
> tək sətirlik  // , çox sətirlik /* */ və  XML üçün /// kommentariya növləri var.

6. Explain sealed class in C#?
6. C# -da möhürlü (qapalı)  sinifi izah edin.
>  Sealed sözü gizli , qapalı, möhürlənmiş  mənalarındadır. Belə ki, hansısa sinifi qapalı(sealed) olaraq təyin etdikdə həmin sinif özündən əvvəlkilərdən miras ala bilir amma miras verə bilmir. Bu daha çox metod və dəyişənlərinin dəyişdirilməsini istəmədiyimiz siniflərdə təyin olunur.

7. Give an example of using sealed class in C#?
7. Möhürlü(sealed) siniflərə nümunə verin.
>  public sealed class SealedClass
  public class A
  public class Z:A
  
8. List out the differences between Array and ArrayList in C#?
8. Array və arrayList-lər arasındakı fərqləri sadalayın.
>  array-lar sabit uzunluqda olur və eyni dəyişən tipinə malik olur , amma arrayList-lərin uzunluğu sabit olmur və fərqli dəyişən tiplərinə malik olmadığı üçün istənilən qədər  dəyişən əlavə etmək olar.

9. Why to use “using” in C#?
9. C# da "using" açar sözü nə üçün istifadə olunur? 
>  using ifadəsi .Net framework-də sinif və ya namespace təyin etmək üçün istifadə edilir.

10. Explain namespaces in C#?
10. C#-da namespace-ləri izah edin.
>   Namespace-lər, sinifləri sərhədləri daxilində saxlayır.Biz namespace-ləri adətən əlaqəli sinifləri qruplaşdırmaq üçün istifadə edirik. Belə ki, namespace-ləri təyin etmək üçün using açar sözündən istifadə edirik.

11. Why to use keyword “const” in C# ? Give an example.
11. const açar sözü C# -da nə üçün istifadə edilir? Misal verin:
>   Proqramlamada hər hansı dəyişən təyin etdikdə onun dəyərinin sonradan dəyişdirilməsi mümkündür. Amma elə dəyişənlər qeyd etmək lazım olur ki , onun dəyərinin dəyişdirilməsini  istəmirik və ya onun dəyəri həmişə sabit olaraq təyin olunur. Bu zaman həmin dəyişənin qarşısına const açar sözünü qeyd etdikdə həmin dəyişənin dəyəri həmişə sabit qalır və sonradan dəyişdirilə bilməz. Misal üçün Pi dəyərinin sabit olaraq 3.14 olduğunu bilirik və 3.14 olaraq qeyd edirik.

12. What is the difference between “constant” and “readonly” variables in C#?
12. C#-da  constant və readonly dəyişənləri arasındakı fərq nədir?
>   const sabit olaraq tərcümə olunur, sinif səviyyəsində təyin edilir və təyin edilərkən mütləq dəyər verilməlidir. Bu dəyər sonra dəyişdirilə bilməz. readonly isə oxuna bilər kimi tərcümə olunur, sinif səviyyəsində təyin olunur.dəyəri ya təyin olunarkən ya da sinif konstruktorunda verilə bilər.Sonradan dəyəri dəyiştirilə bilməz.

13. Explain “static” keyword in C#?
13. c# da  "static" açar sözünü izah edin.
>   static olaraq təyin olunan metodlar və ya dəyişənlər proqram daxilində istənilən sinif və ya namespace-dən  çağırılıb istifadə edilə bilər.

14. What is the difference between “dispose” and “finalize” variables in C#?
14. C# da "dispose" və "finalize" dəyişənləri arasında hansı fərqlər var?
>   Dispose-bu metod İDisposable interface-ni istifadə edir və idarə edilən və idarə edilməyən kodları sərbəst buraxır.
    Finalize-bu metod açıq adlandırılan Dispose metonunun əksinə daxildən çağırılır. Zibil toplayıcı tərəfindən çağırılır və koddan çağırılmaz.


15. How the exception handling is done in C#?
15. Istisna işlənməsi C# -da necə aparılır?
>   xətanın işlənmə ehtimalı olan yerdə try catch blokundan istifadə olunur.

16. Can we execute multiple catch blocks in C#?
16. 


17. Why to use “finally” block in C# ?
17. Niyə C#-da finally blokunu  istifadə edirik?
>   try və catch bloklarindan sonra en sonda yazılır. Try və catch bloklari işə düşdükdən sonra hər nə olursa olsun, en sonda finally bloku işə düşür.istifadə olunmasi istəyə bağlıdır, 



18. What is the difference between “finalize” and “finally” methods in C#?
18. "finalize" və "finally" metodlari arasında hansı fərqlər var?
>  finalize metodu - bildiyimiz kimi C# -da garbage collector var və istifadə olunmayan işlərin yaddaşdan silinməsi funksiyasını yerinə yetirir, bu garbage collector-un işə düşməsindən əvvəl sinifin görəcəyi son işlər finalize metodunun bloklarına yazılır və yerinə yetirilir.
finally metodu - xəta baş verməsi ehtimal olunan kodlar try catch blokunun daxilinə yazılır və bu bloklardakı kodlar xəta baş verməsindən və ya verməməsindən asılı olmayaraq finally metodunun daxilindəki kodlar mütləq işə düşür.

19. What is the difference between “throw ex” and “throw” methods in C#?
19. C# -da “throw ex” və  “throw” arasındakı fərqlər nədir?
>   

20. Can we have only “try” block without “catch” block in C#?
20. c# -da try blokunu catch-siz işlədə bilərik mi?
>   Bəli işlədə bilərik , amma catch-siz işlətsək finally blokunu işlətməliyik.

21. List out two different types of errors in C#?
21. c# -da 2 fərqli xəta tipini sadalayın.
>   tərtibat zamanı xəta və işləmə zamanında xəta

22. Do we get error while executing “finally” block in C#?
22. C#-da finally bloklari çalışdığı zaman xəta alırıq mı?
>   finally bloklari işlədiyi zaman bəzən xəta ala bilirik.

23. Mention the assembly name where System namespace lies in C#?
23. c# -da namespace adı sistemdə harda yerləşir?
>   Assembly Name – mscorlib.dll

24. What are the differences between static, public and void in C#?
24. c#-da static, public və void arasındakı fərqlər nədir?
>   static siniflərə, metodlara və dəyişənlərə objekt yaratmadan projekt daxilində çatmaq mümkündür
    public metod və dəyişənlərə proyekt daxilində objekt yaradaraq çatmaq mümkündür.
    void heç bir dəyər qaytarmayacağını bildirmək üçün istifadə edilir.
    
25. What is the difference between “out” and “ref” parameters in C#?
25. c#-da out və ref parametrləri arasındakı fərqlər nələrdir?
>   C# da, proqram sinfinin daxilində bir parametrli metod teyin edib(parametrin qarşısında ref yazaraq), onu Main metodunda dəyər təyin edib çağırmaq istədikdə ref açar sözündən istifadə edirik və bu zaman metodu işə salaraq dəyərini ekrana çıxartmaq mümkündür. Əgər metoddakı parametrə metod daxilində dəyər təyin edib hesablamasını ekrana çıxarmaq istədikdə, metodun daxilində onun dəyərini təyin edirik, metodun parametrinin qarşısında out yazırıq, daha sonra Main metodunda sadəcə metodun adını çağıraraq parametrin qarşısına metoddakı kimi out açar sözünü yazıb hesablamanı ekrana çıxarda bilərik.

26. Explain Jagged Arrays in C#?
26. Jagged(nizamsız) array-ları izah edin.
>   Nizaminsız array-lar hər bir sətri fərqli ölçüdə olan arraylardır.yazılışı aşağıdakı kimidir:
    int[][] nizamsız_array={new int[]{1},
                            new int[]{1,2,3}
                            new int[]{1,2}};

27. Can we use “this” inside a static method in C#?
27. this açar sözünü static metod daxilində istifadə edə bilərikmi?
>   this açar sözünü static metod daxilində istifadə edə bilmərik.

28. What are value types in C#? 
28. C#-da deyer tipleri hansılardır?
>   c#-da aşağıdakı dəyər tipləri vardır:
    int, double, float, long, ulong, enum, byte, sbyte, decimal

30. What are reference types in C#?
30. c#-da referans tipləri hansılardır?
>   class, string, interface, object.

31. Can we override private virtual method in C#?
31. c#-da private(özəl) virtual metodu silib üzərinə yaza bilərikmi?
>   xeyr, private(özəl) metoda öz bloklarından kənardan müraciət edə bilmədiyimiz üçün onu silib üzərinə     yaza bilmərik

32. Explain access modifier – “protected internal” in C#?
32. c#-da təyinetmə göstəricilərindən  olan daxili qorunan göstəricisini izah edin.
>   daxili qorunan olaraq təyin olunmuş objekt təyin olunduğu sinifin içərisindən və o sinifdən yaradılmış digər siniflər içərisindən çağırıla bilər.Həmçinin eyni assembly içərisində olmasalar belə təyin olunduğu digər siniflərdən də çağırıla bilər.

33. In try block if we add return statement whether finally block is executed in C#?
33. ?????????????????????????????????


34. What you mean by inner exception in C#?
34. ?????????????????????????????????

35. C# da String Builder klasın izah edin.
35. c#-da string birləşdirici sinifini izah edin.
>   string birləşdirici sinifi + operatoru ilə string tipində dəyişənlərin birləşdirilməsi funksiyasını yerinə yetirir.Bu prosesi append() metodu vasitəsilə yerinə yetirərkən digər tiplərdən olan dəyərlər də toString() metodu ilə string tipinə çevrilərək birləşdirilir.

36. What is the difference between “StringBuilder” and “String” in C#?
37. What is the difference between methods – “System.Array.Clone()” and “System.Array.CopyTo()” in C#?
38. Can you store multiple data types in an array?
