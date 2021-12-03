// 7. Показать числа от -N до N
Console.WriteLine("Введите n: ");
int n = int.Parse(Console.ReadLine());

if (n>0)
{
    int x = -n;
    while (x <= n)
    {
        Console.WriteLine(x); 
        Console.Write(" ");
        x++;
    }
}
else
{
    int x = n;
    while (x <= n* - 1)
    {
         Console.WriteLine(x); 
         Console.Write(" ");
         x++;
    }
}