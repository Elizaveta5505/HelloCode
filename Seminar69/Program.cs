// 68. Показать натуральные числа от M до N, N и M заданы
string Number (int M, int N)
{
    if(M>N) return $"{M} " + Number(M-1, N);
    else if (N>M) return $"{M} " + Number(M+1, N);
    else return M.ToString();
}
Console.WriteLine(Number(1, 3));
