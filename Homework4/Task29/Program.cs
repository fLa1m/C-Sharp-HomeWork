// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int Prompt(string message)
{
    Console.Write(message); // Выводим приглашение к вводу
    string readInput = Console.ReadLine(); // Вводим значение
    int result = int.Parse(readInput); // Приводим к числу
    return result;
}

int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine("]");
}

int length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение для диапазона случайного числа: ");
int max = Prompt("Конечное значение для диапазона случайного числа: ");
int[] array = GenerateArray(length, min, max);
PrintArray(array);

// void FillArray(int[] row)
// {
//     for (int i = 0; i < row.Length; i++)
//     {
//         row[i] = new Random().Next(50);
//     }
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i == arr.Length - 1)
//         {
//             Console.Write($"{arr[i]}]");
//         }
//         else
//         {
//             Console.Write($"{arr[i]},");
//         }
//     }
// }

// Console.Clear();
// int[] array = new int[8];
// FillArray(array);
// PrintArray(array);