// 30. Показать кубы чисел, заканчивающихся на четную цифру
int number = new Random().Next (1, 10);
Console.WriteLine(number);
for (int i = 0; i < number; i++)
{
    if (Math.Pow(i, 3) %2 == 0) Console.WriteLine(Math.Pow(i, 3));
}