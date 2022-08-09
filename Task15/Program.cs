// Задача 15: Напишите программу, которая 
// 1. принимает на вход цифру, обозначающую день недели, и 
// 2. проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру от 1 до 7, обозначающую день недели: ");
int dayNum = Convert.ToInt32(Console.ReadLine());

if ( dayNum < 1 || dayNum > 7 )
{
    Console.WriteLine("Число вне диапазона от 1 до 7.");
    return;
}

if ( dayNum <= 5 ) Console.WriteLine($"День под номером {dayNum} не является выходным.");
else Console.WriteLine($"День под номером {dayNum} - это выходной.");
