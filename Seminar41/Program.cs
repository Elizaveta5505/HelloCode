// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
void FillArray(double[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().NextDouble () + new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(double[] arr)
{
    int count = arr.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(arr[position]);
        position++;
    }
}

double[] array = new double[5];
FillArray(array);
PrintArray(array);
double Max = 0;
double Min = double.MaxValue;
for(int i = 0; i < array.Length; i++)
{
    if (array[i] > Max) Max = array[i];
    if (array [i] < Min) Min = array[i];
}
Console.Write("Разница между максимальным и минимальным элементами равна: ");
Console.WriteLine($"{Max} - {Min} = {Max - Min}");