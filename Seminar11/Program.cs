﻿// 10. Показать вторую цифру трёхзначного числа
int number = int.Parse(Console.ReadLine());
Console.WriteLine(number%100/10);
// %100 - показывает две последних цифр числа
// /10 - показывает две первые цифры числа
// в сочетании они показывают вторую цифру (для бОльших чисел предпоследнюю)
