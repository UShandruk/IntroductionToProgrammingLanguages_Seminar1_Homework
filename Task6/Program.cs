﻿// Задача 6
// Напишите программу, которая на вход принимает число
// и выдает, является ли число четным (делится ли на два без остатка).
// Пример:  4 => да
//         -3 => нет
//          7 => нет

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
string result = a % 2 == 0 ? "Да" : "Нет";
Console.Write(result);