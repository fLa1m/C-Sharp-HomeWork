// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.WriteLine("Введите три числа:");
int NumOne = int.Parse(Console.ReadLine());
int NumTwo = int.Parse(Console.ReadLine());
int NumThree = int.Parse(Console.ReadLine());
int MaxNum = NumOne;

if (NumTwo > MaxNum) MaxNum = NumTwo;
if (NumThree > MaxNum) MaxNum = NumThree;

Console.Write("Максимальное число: " + MaxNum);
