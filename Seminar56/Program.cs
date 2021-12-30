// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ArithmeticMean(int[,] matrix)
{
    int sum = 0;
    int average = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];
            average = sum / matrix.GetLength(0);
        }
        Console.WriteLine($"Среднее арифметическое {j + 1} столбца: {average}");
        sum = 0;
        average = 0;
    }
}
int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);
ArithmeticMean(matrix);