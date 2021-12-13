// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
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

int[] array = new int[5];
FillArray(array);
PrintArray(array);
int mult = 1;
for (int i = 0; i < array. Length; i++)
{
    mult = array[i] * array [array.Length - 1 - i];
    Console.WriteLine($"{mult} = {array[i]} * {array [array.Length -1 - i]}");
}
