﻿// 9. Показать последнюю цифру трёхзначного числа
int number = int.Parse(Console.ReadLine());
Console.WriteLine(number%10);
// %10 - показывает последнюю цифру числа
// %100 - показывает две последних цифр числа
// /10 - показывает две первые цифры числа (для трёхзначного)
// /100 - показывает первую цифру числа (для трёхзначного числа)