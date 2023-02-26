// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumber(int a, int b)
{
    if (a > b) { return 0; }
    else { return a + SumNumber(a + 1, b); }
}

int DataInput(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int m, n;
do
{
    m = DataInput("Введите начало интервала: ");
    n = DataInput("Введите конец интервала: ");
    if (m > n) { Console.WriteLine("Начальное значение интервала должно быть больше конечного."); }
} while (m > n);
Console.WriteLine(SumNumber(m, n));