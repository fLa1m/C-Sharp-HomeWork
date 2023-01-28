// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.WriteLine("Введите число:");
int Num = int.Parse(Console.ReadLine());
int Digit = 2;

if (Num == 1) Console.Write("Четных чисел нет.");
if (Num > 1)
{
    while (Digit <= Num)
    {
        Console.Write(Digit + " ");
        Digit += 2;
    }
}
if (Num < 1) Console.Write("Число меньше 1.");