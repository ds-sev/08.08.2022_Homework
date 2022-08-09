﻿// Задача 10: 
// Напишите программу, которая 
// 1. принимает на вход трёхзначное число и 
// 2. на выходе показывает вторую цифру этого числа. 
// Решить без использования строк.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

if ( a / 100 == 0 || a / 100 > 9  || a / 100 < -9 )
{
    Console.WriteLine($"Введенное число {a} не является трёхзначным.");
    return;
}
if ( a > 0 )
{
    Console.WriteLine($"Вторая цифра числа {a}: {( a % 100 ) / 10 }");
}
else
{
    Console.WriteLine($"Вторая цифра числа {a}: {(( a % 100 ) / 10) * -1 }");
}




