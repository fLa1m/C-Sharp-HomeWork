// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли
// этот день выходным.

Console.Clear();
Console.Write("Введите цифру дня недели: ");
int Num = int.Parse(Console.ReadLine());

if (Num >= 1 && Num <= 7)
{
    Console.Write("Это выходной день? ");
    if (Num == 6 || Num == 7)
    {
        Console.WriteLine("Да.");
    }
    else
    {
        Console.WriteLine("Нет.");
    }
}
else
{
    Console.WriteLine("Такого дня недели нет.");
}