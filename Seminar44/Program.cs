// 43. Написать программу преобразования десятичного числа в двоичное
Console.Write("Введите дисятичное число: ");
int decimalNumber = int.Parse(Console.ReadLine());
int transformation;
string result = string.Empty;
while (decimalNumber > 0)
{
    transformation = decimalNumber % 2;
    decimalNumber /= 2;
    result = transformation.ToString() + result;
}
Console.Write("Двоичное число: ");
Console.WriteLine(result);