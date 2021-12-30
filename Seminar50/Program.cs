// 49. Показать двумерный массив размером m×n заполненный вещественными числами
void FillArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().NextDouble () + new Random().Next(1, 10);
        }
    }
}
void PrdoubleArray(double[,] matrix)
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

double[,] matrix = new double[2,2];
FillArray(matrix);
PrdoubleArray(matrix);