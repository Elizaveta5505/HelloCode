// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
         array [index] = new Random().Next(0, 10);
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
int [] array = new int [12];
FillArray(array);
PrintArray(array);
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    sum = sum + array[i];
}
Console.Write("Сумма элементов массива равна: ");
Console.WriteLine(sum);
