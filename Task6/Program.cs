// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).

Console.Clear();
Console.WriteLine("Введите число:");
int Num = int.Parse(Console.ReadLine());
Console.WriteLine("Число четное?");

if (Num % 2 == 0) Console.WriteLine("Да.");
else Console.WriteLine("Нет.");