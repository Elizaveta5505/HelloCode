// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.WriteLine("Введите координату х: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату у: ");
int y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0) Console.WriteLine("первая четверть плоскости");
if (x < 0 && y > 0) Console.WriteLine("вторая четверть плоскости");
if (x < 0 && y < 0) Console.WriteLine("третья четверть плоскости");
if (x > 0 && y < 0) Console.WriteLine("четвёртая четверть плоскости");