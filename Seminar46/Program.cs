﻿// 45. Показать числа Фибоначчи
double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}
for (int i = 1; i < 8; i++)
{
    Console.Write(Fibonacci(i));
}