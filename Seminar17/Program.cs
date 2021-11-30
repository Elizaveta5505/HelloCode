// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 
Console.WriteLine("Введите число");
int C = int.Parse(Console.ReadLine());
if (C>5)
{
    Console.WriteLine("Выходной!");
}
else
{
    Console.WriteLine("Будний день");
}