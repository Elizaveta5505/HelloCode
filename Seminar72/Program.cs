// 71. Написать программу вычисления функции Аккермана
int functionAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return functionAkkerman(m - 1, 1);
    if (m > 0 && n> 0) return functionAkkerman(m - 1, (functionAkkerman(m, n - 1)));
    return 0;
}
Console.WriteLine(functionAkkerman(5, 5));