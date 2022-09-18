//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 //заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 //значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double IntersectionPointx(double b1,double k1,double b2,double k2)
{
   double x =(b2-b1)/(k1-k2);
      return x;
 }
 double IntersectionPointy(double b1,double k1,double b2,double k2)
{
     double y =(b1*k2-b2*k1)/(k2-k1);
   return y;
 }
Console.Write("Введите свободный член b1 = ");
double free1 = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите угловой коэффициент k1 = ");
double angular1 = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите свободный член b2 = ");
double free2 = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите угловой коэффициент k2 = ");
double angular2 = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write("Координаты пересечения прямых: ");  
Console.Write($"x = {IntersectionPointx(free1, angular1, free2, angular2)} ;");
Console.WriteLine($"y = {IntersectionPointy(free1, angular1, free2, angular2)} "); 