// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 
void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
         array [index] = new Random().Next(0, 2);
         index++;
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
         Console.Write(array [position]);
         position++;
    }
    Console.WriteLine();
}
int [] array = new int [8];

FillArray(array);
PrintArray(array);