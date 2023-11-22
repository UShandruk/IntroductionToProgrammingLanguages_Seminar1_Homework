// Задача 2
// Напишите программу, которая на вход принимает два числа
// и выдает, какое число большее, а какое меньшее.
// Пример: a =  5; b =  7 => max =  7
//         a =  2; b = 10 => max = 10
//         a = -9; b = -3 => max = -3

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

//int max = a > b ? a : b;
int max = a;
if(b > a)
max = b;
Console.Write($"max = {max}");