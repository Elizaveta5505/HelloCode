// 27. Определить количество цифр в числе
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int result = 0;
while (number > 0)
{
    number = number/10;
    result++;
}
Console.Write ("Количество цифр в числе: ");
Console.WriteLine(result);