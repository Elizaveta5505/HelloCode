// 34. Написать программу замену элементов массива на противоположные
void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
         array [index] = new Random().Next(-10, 10);
         index++;
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
         Console.WriteLine(array [position]);
         position++;
    }
}
int [] array = new int [5];
FillArray(array);
for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * (-1);
}
PrintArray(array);
Console.WriteLine();
