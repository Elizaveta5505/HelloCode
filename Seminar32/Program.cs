﻿// 31. Задать массив из 8 элементов и вывести их на экран 
void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
         array [index] = new Random().Next(1, 10);
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
int [] array = new int [8];

FillArray(array);
PrintArray(array);
Console.WriteLine();