// 24. Найти кубы чисел от 1 до N
Console.WriteLine("Введите число N:");
int N = int.Parse(Console.ReadLine());
for (int num = 1; num <= N; num++)
{
    Console.WriteLine(Math.Pow(num, 3));
}