// 22. Найти расстояние между точками в пространстве 2D/3D
int[] A = {3, 8};
int[] B = {5, 6};
int result = 0;
for (int i = 0; i < A.Length; i++)
{
    for (int j = 0; j < B.Length; j++)
    {
        Console.WriteLine(result == (result + (B[j] - A[i])*(B[j] - A[i])));
    }
}