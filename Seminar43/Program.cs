// 42. Определить сколько чисел больше 0 введено с клавиатуры
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
string num = number.ToString();
int[] array = new int[num.Length];
for(int i = 0; i < num.Length; i++)
{
    array[i] = int.Parse(num[i].ToString());
}
int count = 0;
for(int j = 0; j < array.Length; j++)
{
    if (array[j] >= 1)
    {
        count = count + 1;
    }
}
Console.Write ("Количество чисел больше 0: ");
Console.WriteLine(count);