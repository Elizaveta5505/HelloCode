// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(1, 1000);
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

int[] array = new int[123];
FillArray(array);
PrintArray(array);
int elements = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 9 && array[i] < 100)
    {
        elements = elements + 1;
    }
}
Console.Write("Количество элементов из отрезка: ");
Console.WriteLine(elements);