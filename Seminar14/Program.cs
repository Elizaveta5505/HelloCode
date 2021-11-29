// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток
int number = int.Parse(Console.ReadLine());
int numA = 5;
if(number/numA == 0)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine(number%numA);
}