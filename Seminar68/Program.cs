// 67. Показать натуральные числа от N до 1, N задано
string Number (int a)
{
    if(a>=1) return $"{a} " + Number(a-1);
    else return String.Empty;
}
Console.WriteLine(Number(10));