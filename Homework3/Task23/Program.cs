// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int Count;

if (N == 0)
{
    Console.WriteLine("Введите число отличное от 0.");
}
else if (N > 0)
{
    Count = 1;
    Console.WriteLine("Таблица кубов: ");
    while (Count <= N)
    {
        if (Count == N)
        {
            Console.Write($"{Math.Pow(Count, 3)}.");
        }
        else
        {
            Console.Write($"{Math.Pow(Count, 3)}, ");
        }
        Count++;
    }
}
else
{
    Count = -1;
    Console.WriteLine("Таблица кубов: ");
    while (Count >= N)
    {
        if (Count == N)
        {
            Console.Write($"{Math.Pow(Count, 3)}.");
        }
        else
        {
            Console.Write($"{Math.Pow(Count, 3)}, ");
        }
        Count--;
    }
}