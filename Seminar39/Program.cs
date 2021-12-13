// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(1, 10);
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
FillArray(array);
PrintArray(array);
int sum = 0;
for (int i = 1; i < array.Length; i = i + 2)
{
    sum = sum + array[i];
}
Console.Write("Сумма элементов на нечётной позиции: ");
Console.WriteLine(sum);