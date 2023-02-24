//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
//  строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int DataInput(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SumOfRow(int[,] array)
{
    int minSum = 0;
    int rowSum = 0;
    int minRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minSum += array[0, i];
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowSum += array[i, j];
        }
        if (rowSum < minSum) { minSum = rowSum; minRow = i; }
        rowSum = 0;
    }
    Console.WriteLine($"Минимальная сумма в {minRow + 1} строке.");
}

Console.Clear();
int rows = DataInput("Введите количество рядов: ");
int columns = DataInput("Введите количество столбцов: ");
int[,] matrix = FillArray(rows, columns);
Console.WriteLine();
PrintArray(matrix);
SumOfRow(matrix);