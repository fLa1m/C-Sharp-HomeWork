// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int m, int n)
{
    if (m == 0) { return n + 1; }
    else if (m > 0 && n == 0) { return Akkerman(m - 1, 1); }
    else { return Akkerman(m - 1, Akkerman(m, n - 1)); }
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
    m = DataInput("Введите первое число: ");
    n = DataInput("Введите второе число: ");
    if (m < 0 || n < 0) { Console.WriteLine("Числа должны быть > 0."); }
} while (m < 0 || n < 0);
Console.WriteLine($"A({m},{n}) = {Akkerman(m, n)}");