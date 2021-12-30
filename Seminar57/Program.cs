// 56. Написать программу, которая обменивает элементы первой строки и последней строки
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
void ExchangeArray(int[,] matrix)
{
    int size = matrix.GetLength(0);
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int elements = matrix[0,j];
        matrix[0, j] = matrix[size - 1, j];
        matrix[size - 1, j] = elements;
    }
}

int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
ExchangeArray(matrix);
PrintArray(matrix);