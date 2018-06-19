# Top-100-csharp-interview-question
Top 100 C# Interview Questions

1. C# nədir? 
> C#, özündə  böyük əməliyyatlar ehtiva edən, özündə böyük məlumat daşıyan - ötürən, bir şirkətin virtual idarə edilməsi üçün lazım olan bir proqram(CRM) yazmaq üçün  hər şeyi özündə birləşdirən proqramlaşdırma dilidir. C# real dünya obyektlərini daha aydın şəkildə virtual aləmdə tətbiq etmək üçün ən səmərəli dillərdən biridir.

2. Explain the features of C#?
> Ən vacib xüsusiyyətlərindən bir neçəsi : müasir tələblərə cavab verməsi; müasir texlogiyalar tərəfindən sürətli işlədilməsi; bütün bunlarla yanaşı sadə olması, yəni asan başa düşülməsi, strukturlu olması; eyni anda bir proqramın ərsəyə gəlməsi üçün bir neçə proqramçının işləyə bilməsi; bunlardan ən əsası obyekt yönümlü olması. C# digər proq. dillərinin bütün çatışmayan xüsusiyyətlərini özündə tamamlayan bir dildir.

3. C#-ın üstünlüklərindən ən vaciblərini sadalayın.
> Asan oxunaqlı olması; sürətli kod yazmaq üçün method, shortcurt və keyvord ların çoxluğu; hemin keyvord ların mənasının asan başa düşülməsi; Visual Studio kimi bir İDE sinin olması (avtomatik error göstərdiyinə görə, kodda səhv olmasa belə run time vaxtı exeption nın step by step göstərməsi).

4. What are IDE’s provided by Microsoft for C# development?
> Microsoft tərəfindən c# üçün verilmiş İDE lərdən ən vacıbləri bunlardır:
Visual Studio (Code);
Productivity Power Tools (all versions);
 .NET Fiddle

> Visual Studio Code (all versions)
5. Explain the types of comments in C#?
> C# da mən bildiyim qədərilə 2 comment üsulu var :
 1. " // " ;
2. " /* ... *\ " 

6. Explain sealed class in C#?
7. Give an example of using sealed class in C#?
" Sealed " class OOP nin miras xüsusiyyətlərini məhdudlaşdırmaq üçün istifadə olunur. Hər hansı bir class "sealed" keyvordu ilə bəyan edildikdə miras alına bilmir. "sealed" eyni zamanda həm atributlara həm də method lara təyin oluna bilsə də "sealed" keyvord unun bu xüsusiyyəti onlara aid edilmir. Sadəcə class üzrə təyin oluna bilir. 2 misalla visualda izah edəcəm

8. List out the differences between Array and ArrayList in C#?
> hər 2sinin oxşarlıqı ondan ibarətdir ki, 1 dən çox datanı saxlamaq üçün istifadə olunur.
Array lərin Listlərdən başlıca xüsusiyyəti ondan ibarətdir ki, array lər sabit elementləri saxlamaq üçündür. List lərdə isə datanın sayı avtomatik təyin olunduğundan başda sayı bildirmək lazım deyil. 
Bir array təyin etdikdən sonra onun elementlərini artırmaq olmur. List lərə isə sonradan istənilən sayda element artırmaq mümkündür.
Bir array təyin edilərkən ancaq təyin edildiyi tipin elementlərini daşıya bilir. Listlərdə isə istənilən növ tipin elementlərini saxlamaq mümkündür.
Bir Array yalanız " using System; " namespace ilə istfadə edildiyi halda ArrayList " using System.Collections; " namespace ilə istfadə edilir.

9. C# da "using" nə üçün istifadə olunur
> "using" keyvordunun 2 istifadə yeri var :
Directive kimi :
C#  da "using" keyvord u fərqli namespace lərin müxtəlif classlarını və methodlarını istifadə etmək üçün istifadə olunur.
Statement kimi :
Məllim bu SQL ə aiddir, amma biz onu keçməmişik deyə çox baxmadım 2-ci istifadə yerinə

10. Explain namespaces in C#?
> "namespace" keyvvord u c# da 2cür istifadə ediə bili :
1cisi : Öz lahiyələrimizi yazan zaman çoxlu class istifdə etdiyimiz zaman.
Buç class ların idarə edilmsi və onların başqa namespace lərdə istifadəsini asanlaşdırır
2cisi : Öz lahiyələrimizdə c#  tərəfindən yazılmış hazır class ların methodlarını istifadə etmək üçün. Məsələn müəyyən bir nəticəni ekrana çixartmaq üçün istifadə olunan Console class ının methodu olan WritLine() method unu istifadə edə bilmirik. Bu zaman CİL(Common İntermadiete Language) ikinci adı ilə .Net platformu System class ından istifadə edir: System.Console.WritLine(); bunun qarşısını almaq üçün, ümumiyyətlə c# da bunun kimi müxtəlif methodları sərbəst istifadəsini asanlaşdırmaq üçün "namespace" keyvord undan istifadə edilir.

11. Why to use keyword “const” in C#? Give an example.
>"const" keyword u bir class daxilində və ya bir proq da sabit qalacaq dəyişənləri declare etmək üçün istifadə olunur. Adi dəyişəndən fərqi ondan ibarətdir ki, onu dəyər vermədən bəyan etdiyimiz halda "const" la bəyan etdiyimiz bir dəyişənə mütləq sürətdə bir dəyər assign etməliyik əksi halda səhv yaranacaq. Bütün numeric data type larla, o cümlədən Bool tipi ile, string lərlə, null tipi ilə işlənə bilir. Class daxilində ancaq atributlara təyin oluna bilir. Method lara təyin oluna bilməz. Static keyword u ilə təyin edilə bilməz. Onsuz da "const" özü static xüsusiyyəti daşıyır. Çünki adi class da olan adi və "const"la olan property yə fərqli cür müraciət olunur. Adi property yə class dan yaranmış obyektlə, "const"la olan property yə class vasitəsilə müraciət etmək mümkündür. Məs : Visual a baxın.
 Amma "const" istifadəsində bir şeyoi nəzərə almaq lazımdır ki, proqram daxilində uzun zaman sonra dəyişəcək dataları "const" la vermək düzgün deyil. Məs: məhsulun növünü, qiymətini hətta şirkətin şüar və şirkəti digərlərindən fərqləndirən xüsusiyyətləri belə const la vermək düzgün deyil. Bir const dəyəri verən zaman sonradan onu override etmek olmur.

12. What is the difference between “constant” and “readonly” variables in C#?
> "readonly" keyword u const kimi yenə sabit dəyərlər yaratmaq üçün istifadə olunur. Fərqi ondan ibarətdir ki, const un sonradan dəyərini dəyişdirmək olmursa, "readonly" nin dəyərini dəyişdirmək mümkündür. Ancaq class daxilində bəyan edilə bilir. Const la bəyan edilən bir dəyərə ancaq class la müraciət etmək mümkündürsə readonly ilə bir property yə obyekt vasitəsilə müraciət etmək olur. Readonly nin dəyərini sonradan dəyişdirmək mümkündür, ancaq bu const da olmur.

13. Explain “static” keyword in C#?
14. What is the difference between “dispose” and “finalize” variables in C#?
15. How the exception handling is done in C#?
> C# da  exeption problemi yazılan kodda səhv yaranan zaman meydana çıxır və proq. ın cash olmasına səbəb olur. Bunu aradan qaldırmağın 3 üsulu var:
Try - catch();
Try - finally();
Try - throw()

16. Can we execute multiple catch blocks in C#?
> Bir namespace error problemlərini həll etmək üçün 1dən çox catch methodu əlavə etmək mümkündür. Hər bir exception methodu System.Exception class ından inheritance aldığına görə bu class dan ancaq 1 catch almaq olur. 1dən çox catch  istifadə etmək üçün başqa bqaşqa namespace ləri istifadə etmək lazimdir. Ancaq onlardan yalnız biri işləyəcək
misal olaraq Visualda kod seklinde yazmisam : ...

17. Why to use “finally” block in C#?
> Əgər yazılan kodun səhv olması ehtimalı yüksəkdirsə, həmin hissə try blokunun içində yazılır catch metodu isə o səhvi tutur ekrana çıxartmır və dolayısı ilə prog crash olunmasının da qarşısını alır əvəzinə biz istədiyimiz nəticəni çıxardır. Amma bunun bir "finally"  keyvordu da var ki, catch metodunun əvəzinə proq crash olunsa belə ekrana fəqrli nəticə çıxardır. Məs: mən 2 fərqli tipdən olan dəyərlərdən birini digərinə çevirən zaman ortaya çıxan problemi finally ilə verməyə çalışacam Visualda kod şəklində yazmışam : ...

18. What is the difference between “finalize” and “finally” methods in C#?
19. What is the difference between “throw ex” and “throw” methods in C#?
20. Can we have only “try” block without “catch” block in C#?
 > Try ifadəsini catch olmadan finally ifadəsi ilə vermək mümkündürş Ancaq tək işlənməsi mümkün deyil. Çünki try kodda səhv olan hissəni bildirir. Bu səhv olan hissəni tutub saxlamaq lazimdir proq. crash olmasın. Bunu da catch olmadan finally vasitəsilə vermək mümkündür.

21. List out two different types of errors in C#?
> 3cür error tipi var :
Syntax Error;
Run-Time Errors;
Logical Errors;
Bunlardan 1cisi sadə və ən çox edilən error lardandır. Bu errorlar proq. dillərindən asılı olaraq dəyişir. C# dili visual studioda yazildiğindan bu İDE bize avtomatik xətanı bildirir. məs: yazilan kod sətrinin axırında ; işarəsini qoymamaq, string tipində bir dəyişən təyin edib dəyərini int lə vermək və.s
Run-time error ları proqramda heç bir sintaks erroru olmasa belə prog. işləyən zaman meydana çıxan səhvlərdir. Məs : int tipində bir dəyişən təyin edib onu 0 - a bölüb ekranda göstərmək istəsək prog. crash olacaq
Logical errorları o deməydiki prog. tam işliyir amma istifadəçiyə təqdim edilmiş proqramda istifadəçinin daxil etdiyi yalnış dəyərlər üzündn meydana çıxan errorlar. Məs: istifadəçi yaşını hesablamaq üçün - ədəd daxil edirsə və ya rəqəm əvəzinə yazı, simvol daxil edirsə, proq işləməyəcək
22. Do we get error while executing “finally” block in C#?
23. Mention the assembly name where System namespace lies in C#?
> System namespace nin c# da yeri - mscorlib.dll
24. What are the differences between static, public and void in C#?
> static keyword u class dan asılı olmayaraq bir dəyişəni, property ni və ya bir metodu namespace daxilinde istənilən yerdə istifadə etmək üçün istifadə olunur. Static lə bir class ı da bəyan etmək mümkündür. Bu zaman class ın bütün property və metodları da static olacaq. Bu class ın metod və peoperty lərinə müraciət etmək üçün obyekt yaratmaq lazım deyil, birbaşa class dan müraciət etmək mümkündür. Məs : Visual da nümunə vermişəm

25. What is the difference between “out” and “ref” parameters in C#?
> Out və Ref metodları müəyyən bir dəyişənin dəyərini jər hansı bir metodun içinə parametr kimi ötürərək dəyişdirilməsidir. Bunlar arasında yeganə fərq ondan ibarətdir ki, out metoduna parametr kimi ötürəcəyimiz dəişənə əvvəlcədən dəyər assign etməyə ehtiyyac yoxdur, amma ref metoduna parametr kimi ötürəcəyimiz dəyişənə mütləq dəyər təyin etməliyik. Allaha and olsun ki, kurs başlayannan bəri indi başa düşdüm buların fərqin. Visual da kod şəklində vermişəm

26. Explain Jagged Arrays in C#?
> Array lər dedik ki, məlum bir data type ın sabit dəyərlərini saxlamaq üçün bir qabdır. Amma  array lər arasında elə bir array növü var ki, onun elementlərinə də ayrı ayrılıqda array təyin edə bilir ki, onun da adına jagged array deyilir. Adi array dən fərqi yoxdur. Təyin olunma qaydası belədir :         " [][] ". Visual da kod şəklində misallar vermişəm

27. Can we use “this” inside a static method in C#?
> This keyword ü hər hansı bir klasdan yaranan obyektə işarə edir. Static keyword ü isə class member sayılmayıb hər hansı bir namespace səviyyəsində əlçatılan hər hansı bir dəyişəni, metodu, property ni işarə edir. Əgər class daxilində təyin olunubsa, bir başa class dan müraciət olunur. Class ın static olmayan property və ya metodunu static metodun içinə ötürməyi  2 üsulu var. Visualda verdiyim misalda ForThis() mənə ForThisİnStaticMethod() class ı tipində bir obyekt qaytaracaq, sonra isə ForStatic() metodu da bizə yenə də ForThisİnStaticMethod() klası tipində bir obyekt qaytaracaq.

28. What are value types in C#? C#-da deyer tipleri nedir ne demekdir? 
30. What are reference types in C#?
31. Can we override private virtual method in C#?
> protected internal access modifier in əsas məğzi ondan ibarətdir ki, bu modifikatorla təyin olunmuş istənilən metod və ya property ni ancaq miras alındığı class istifadə edə bilər. İnsan üzərindən danışsaq belə deyə bilərəm ki, Babanın bu xüsusiyyətini ancaq ata daşıya bilər, sonradan nəvə və başqaları bu xüsusiyyəti daşıya biməzlər
32. Explain access modifier – “protected internal” in C#?
33. In try block if we add return statement whether finally block is executed in C#?
34. What you mean by inner exception in C#?
35. C# da String Builder klasın izah edin.
36. What is the difference between “StringBuilder” and “String” in C#?
37. What is the difference between methods – “System.Array.Clone()” and “System.Array.CopyTo()” in C#?
38. Can you store multiple data types in an array?
