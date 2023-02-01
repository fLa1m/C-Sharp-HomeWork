// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.Write("Введите число: ");
int Num = int.Parse(Console.ReadLine());
int Digit = Num;
int DigitAmount = 0;

while (Digit != 0)
{
    Digit /= 10;
    DigitAmount++;
}

int UselessNumbers = DigitAmount - 3;

if (DigitAmount < 3)
{
    Console.WriteLine("Третей цифры нет");
}

else if (DigitAmount == 3)
{
    Console.WriteLine("Третья цифра: " + (Num % 10));
}

else
{
    while (UselessNumbers != 0)
    {
        Num /= 10;
        UselessNumbers--;
    }
    Console.WriteLine("Третья цифра: " + (Num % 10));
}