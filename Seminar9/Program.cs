// 8. Показать четные числа от 1 до N
Console.Write ("Введите значение n: ");
int n = int.Parse(Console.ReadLine());
int a = 1;

while (a<n)
{
     if (a%2 == 0)
     {
         Console.WriteLine(a++);
         
     }
     a++;
}