// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int MathMethod(int num1, int num2)
{
    int temp = num1;
    for (int i = 1; i < num2; i++)
    {
        temp *= num1;
    }
    return temp;
}

Console.Clear();
Console.Write("Введите основание степени: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите показатель степени: ");
int B = int.Parse(Console.ReadLine());

if (B <= 0)
{
    Console.WriteLine("Введите число больше нуля.");
}
else
{
    Console.WriteLine($"Число {A} в степени {B} = {MathMethod(A, B)}");
}