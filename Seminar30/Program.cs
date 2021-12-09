// 29. Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите N");
int N = int.Parse(Console.ReadLine());
int mult = 1;
for (int num = 1; num <= N; num++)
{
    mult = mult * num;
}
Console.Write ("Произведение чисел равно:");
Console.WriteLine(mult);