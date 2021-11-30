// 15. Дано число. Проверить кратно ли оно 7 и 23
Console.WriteLine("Введите число");
int number = int.Parse(ConsoleWriteLine());
for ( number%7 == 0; number%23 == 0 )
{
    Console.WriteLine("Кратно");
}