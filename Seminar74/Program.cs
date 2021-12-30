// 73. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем
int firstN (int a, int b, int N)
{
    if (N == 1) return a;
    if (N == 2) return b;
    return firstN(a, b, N - 1) + firstN(a, b, N - 2);
}
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(firstN(4, 5, i));  
}
