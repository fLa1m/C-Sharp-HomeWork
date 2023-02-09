// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Prompt(string message)
{
    Console.Write(message); // Выводим приглашение к вводу
    string readInput = Console.ReadLine(); // Вводим значение
    int result = int.Parse(readInput); // Приводим к числу
    return result;
}

int SumAllDigit(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}

int number = Prompt("Введите число: ");
Console.WriteLine($"Сумма всех чисел {number} = {SumAllDigit(number)}");

// int NumberOfDigits(int digit)
// {
//     int sum = 0;
//     if (digit != 0)
//     {
//         while (digit != 0)
//         {
//             sum += digit % 10;
//             digit /= 10;
//         }
//     }
//     return sum;
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine($"Сумма цифр = {NumberOfDigits(num)}");