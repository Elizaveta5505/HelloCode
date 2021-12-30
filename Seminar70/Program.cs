// 69. Найти сумму элементов от M до N, N и M заданы
string Number(int M, int N)
{
    if (M > N) return $"{M} " + Number(M - 1, N);
    else if (M < N) return $"{M} " + Number(M + 1, N);
    else return M.ToString();
}
int Sum(int M, int N)
{
    if (M > N) return M + Sum(M - 1, N);
    else if (M < N) return M + Sum(M + 1, N);
    else return M;
}

Console.Write(Number(5, 1));
Console.Write(" = ");
Console.WriteLine(Sum(5, 1));

