// 23. Показать таблицу квадратов чисел от 1 до N 
Console.WriteLine("Введите число N:");
int N = int.Parse(Console.ReadLine());
for (int num = 1; num <= N; num++)
{
    Console.WriteLine($"{num}^2 = " + Math.Pow(num, 2));
}
