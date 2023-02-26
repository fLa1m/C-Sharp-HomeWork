// Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string DecreaseNumber(int a, int b)
{
    if (a < b) { return $"{b}, " + DecreaseNumber(a, b - 1); }
    else if (a == b) { return $"{b}"; }
    else return String.Empty;
}

int i = 1;
Console.Write("Введите начальное значение интервала: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Натуральные числа в промежутке от {num} до {i}:");
Console.WriteLine(DecreaseNumber(i, num));