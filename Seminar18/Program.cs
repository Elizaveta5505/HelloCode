// 17. По двум заданным числам проверять является ли одно квадратом другого
int numA = 3;
int numB = 9;
int result1 = numA * numA;
int result2 = numB * numB;

if (numB == result1) 
{
    Console.WriteLine("numB является квадратом numA");
}
if  (numA == result2)
{
    Console.WriteLine("numA является квадратом numB");
}
else
{
    Console.WriteLine("Не является");
}