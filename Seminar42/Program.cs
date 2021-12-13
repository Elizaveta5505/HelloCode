// 41. Выяснить являются ли три числа сторонами треугольника 
Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число c");
int c = int.Parse(Console.ReadLine());
if (a + b > c && a + c > b && b + c > a)
{
    Console.WriteLine("Числа являются сторонами треугольника");
}
else
{
    Console.WriteLine("Числа не являются сторонами треугольника");
}