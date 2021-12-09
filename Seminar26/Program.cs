// 25. Найти сумму чисел от 1 до А
Console.WriteLine("Введите число A:");
int A = int.Parse(Console.ReadLine());
int sum = 0;
for (int num = 1; num <= A; num++)
{
    sum = sum + num;
}
Console.Write ("Сумма чисел равна:");
Console.WriteLine(sum);