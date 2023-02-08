// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int NumberOfDigits(int digit)
{
    int sum = 0;
    if (digit != 0)
    {
        while (digit != 0)
        {
            sum += digit % 10;
            digit /= 10;
        }
    }
    return sum;
}

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр = {NumberOfDigits(num)}");