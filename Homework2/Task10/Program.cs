// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Введите трехзначное число:");
int Num = int.Parse(Console.ReadLine());
if (Num / 100 == 0) Console.WriteLine("Число не трехзначное.");
else
{
    Console.WriteLine(Num / 10 % 10);
}