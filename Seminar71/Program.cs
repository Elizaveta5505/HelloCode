// 70. Найти сумму цифр числа
int Summa(int a)
{
    if (a / 10 != 0) return a % 10 + Summa(a / 10);
    else return 0;
}
Console.WriteLine(Summa(123));
