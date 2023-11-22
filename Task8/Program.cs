// Задача 8
// Напишите программу, которая на вход принимает число (N)
// а на выходе показывет все чётные числа от 1 до N.
// Пример:  5 => 2, 4
//          8 => 2, 4, 6, 8

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
string result = "";

if(N > 1)
{
    for(int i = 2; i <= N; i += 2)
    {
        result += $"{i}, ";
    }
    result = result.TrimEnd().TrimEnd(',');
}
else
{ 
    result = $"Чётных чисел от 1 до {N} не существует.";
}

Console.Write(result);