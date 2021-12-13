// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
         array [index] = new Random().Next(- 10, 10);
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
int sumPositiveNumbers = 0;
int sumNegativeNumbers = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        sumPositiveNumbers = sumPositiveNumbers + array[i];
    }
    else
    {
        sumNegativeNumbers = sumNegativeNumbers + array [i];
    }

}
Console.Write("Сумма положительных элементов массива равна: ");
Console.WriteLine(sumPositiveNumbers);
Console.Write("Сумма отрицательных элементов массива равна: ");
Console.WriteLine(sumNegativeNumbers);