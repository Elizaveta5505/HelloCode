// 28. Подсчитать сумму цифр в числе
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int sum = 0;
while (number > 0)
{
    sum = sum + (number%10);
    number = number/10;
}
Console.Write ("Сумма цифр в числе: ");
Console.WriteLine(sum);
