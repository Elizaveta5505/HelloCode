// 66. Показать натуральные числа от 1 до N, N задано
string Number (int a)
{
    if(a<=10) return $"{a} " + Number(a+1);
    else return String.Empty;
}
Console.WriteLine(Number(1));
