// 4. Найти максимальное из трех чисел
int A = 1;
int B = 77;
int C = 9;
int max = C;

if (A > max) max = A;
if (B > max) max = B;
if (C > max) max = C;

Console.Write("max = ");
Console.WriteLine(max);