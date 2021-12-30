// 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
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
int[] FindNumber(int[,] matrix, int find)
{
    int[] position;
    position = new int[] {-1};
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == find)
            {
                position = new int[] {i, j};
            }
        }
    }
    return position;
}

    int[,] matrix = new int[3, 3];
    FillArray(matrix);
    PrintArray(matrix);
    int[] position = FindNumber(matrix, 5);
    if (position[0] != -1)
    {
        Console.WriteLine($"Ваши искомые элементы находятся на позиции: {position[0]}, {position[1]}");
    }
    else
    {
        Console.WriteLine("Искомые элементы не найдены");
    }