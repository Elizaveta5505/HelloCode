// 35. Определить, присутствует ли в заданном массиве, некоторое число 
void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(-10, 10);
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

int IndexOf(int[] array, int find)
{
    int count = array.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (array[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.Write("Искомое число имеет индекс - ");
Console.WriteLine(pos);