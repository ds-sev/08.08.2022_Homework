// Задача 13: 
// Напишите программу, которая 
// 1. выводит третью цифру заданного числа 
// 2. или сообщает, что третьей цифры нет. 
// Решить без использования строк.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if ( a / 100 == 0  )           
{
    Console.WriteLine($"Треья цифра во введенном числе {a} отсутствует."); 
    return;                                                                
}
int threeDigitNum = a;                                                     
                                                                           
while ( threeDigitNum / 100 > 10 || threeDigitNum / 100 < -10)             
{
    threeDigitNum = threeDigitNum / 10;
}
if (threeDigitNum > 0)
{
    Console.WriteLine($"Третья цифра введенного числа {a}: {threeDigitNum % 10}");
}    
else
{
    Console.WriteLine($"Третья цифра введенного числа {a}: {(threeDigitNum % 10) * -1}");
}
    