// 26. Возведите число А в натуральную степень B используя цикл
Console.WriteLine("Введите число A:");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень B:");
int B = int.Parse(Console.ReadLine());
if (B > 0) 
{
    Console.WriteLine(Math.Pow(A, B));
}
else
{
    Console.WriteLine("Степень не натуральная");
}