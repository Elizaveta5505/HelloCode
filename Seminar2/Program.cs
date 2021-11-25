// 2. Даны два числа. Показать большее и меньшее число
int number1 = 13;
int number2 = 8;
int max = number1;
int min = number2;

if (number1 > number2)
{
    max = number1;
    min = number2;
    Console.WriteLine(max);
    Console.WriteLine(min);
}
else
{
    max = number2;
    min = number1;
    Console.WriteLine(min);
    Console.WriteLine(max);
}