// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Prompt(string message)
{
    Console.Write(message); // Выводим приглашение к вводу
    string readInput = Console.ReadLine(); // Вводим значение
    int result = int.Parse(readInput); // Приводим к числу
    return result;
}

int Power(int powerBase, int exponent)
{
    int power = 1;
    for (int i = 0; i < exponent; i++)
    {
        power *= powerBase;
    }
    return power;
}

bool ValidateExponent(int exponent)
{
    if (exponent < 0)
    {
        Console.WriteLine("Показатель не должен быть меньше нуля");
        return false;
    }
    return true;
}

int powerBase = Prompt("Введите основание: ");
int exponent = Prompt("Введите показатель: ");
if (ValidateExponent(exponent))
{
    Console.WriteLine($"Число {powerBase} в степени {exponent} равно {Power(powerBase, exponent)}");
}


// int MathMethod(int num1, int num2)
// {
//     int temp = num1;
//     for (int i = 1; i < num2; i++)
//     {
//         temp *= num1;
//     }
//     return temp;
// }

// Console.Clear();
// Console.Write("Введите основание степени: ");
// int A = int.Parse(Console.ReadLine());
// Console.Write("Введите показатель степени: ");
// int B = int.Parse(Console.ReadLine());

// if (B <= 0)
// {
//     Console.WriteLine("Введите число больше нуля.");
// }
// else
// {
//     Console.WriteLine($"Число {A} в степени {B} = {MathMethod(A, B)}");
// }