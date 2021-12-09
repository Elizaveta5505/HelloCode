// 27. Определить количество цифр в числе
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int result = 0;
while (number > 0)
{
    result++;
    number = (number/10);
}
Console.Write ("Количество цифр в числе: ");
Console.WriteLine(result);