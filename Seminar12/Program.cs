// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int number = new Random().Next (10, 100);
Console.WriteLine(number);
if (number%10 > number/10) // если последняя цифра числа больше первой (%10 - показывает последнюю цифру числа, а /10 - показывает первые цифры числа)
{
    Console.WriteLine(number%10);
}
else 
{
    Console.WriteLine(number/10);
}