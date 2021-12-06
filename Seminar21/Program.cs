// 20. Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите номер четверти: ");
int quarter = int.Parse(Console.ReadLine());
if (quarter == 1) Console.WriteLine("X > 0, Y > 0");
if (quarter == 2) Console.WriteLine("X < 0, Y > 0");
if (quarter == 3) Console.WriteLine("X < 0, Y < 0");
if (quarter == 4) Console.WriteLine("X > 0, Y < 0");
if (quarter > 4) Console.WriteLine("Такой четверти нет");