// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();
Console.Write("Введите пятизначное число: ");
int Num = int.Parse(Console.ReadLine());

if (Num < 10000 || Num > 99999)
{
    Console.WriteLine("Число не пятизначное.");
}
else
{
    Console.WriteLine("Число полиндром?");
    if (Num % 10 == Num / 10000 && Num / 10 % 10 == Num / 1000 % 10)
    {
        Console.WriteLine("Да.");
    }
    else
    {
        Console.WriteLine("Нет.");
    }
}