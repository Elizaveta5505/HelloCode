// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(99, 1000);
        index++;
    }
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(arr[position]);
        position++;
    }
}

int[] array = new int[10];
int even = 0;
int odd = 0;
FillArray(array);
PrintArray(array);
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        even = even + 1;
    }
    else
    {
        odd = odd +1;
    }
}
Console.Write("Количество чётных чисел: ");
Console.WriteLine(even);
Console.Write("Количество нечётных чисел: ");
Console.WriteLine(odd);