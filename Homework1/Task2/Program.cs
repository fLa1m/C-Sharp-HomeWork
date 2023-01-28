// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.WriteLine("Введите два числа: ");
int NumOne = int.Parse(Console.ReadLine());
int NumTwo = int.Parse(Console.ReadLine());
Console.Write("max = ");

if (NumOne > NumTwo | NumOne == NumTwo)
{
    Console.Write(NumOne);
}
else
{
    Console.Write(NumTwo);
}