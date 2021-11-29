// 14. Найти третью цифру числа или сообщить, что её нет
int number = int.Parse(Console.ReadLine());
string num = number.ToString();
if (number> 99)
{
    Console.WriteLine(num[2]);
}
else 
{
    Console.WriteLine("no number");
}