// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortingRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int maxPositionColumn = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, maxPositionColumn]) { maxPositionColumn = k; }
            }
            int temp = array[i, j];
            array[i, j] = array[i, maxPositionColumn];
            array[i, maxPositionColumn] = temp;
        }
    }
}

Console.Clear();
int rows = DataInput("Введите количество рядов: ");
int columns = DataInput("Введите количество столбцов: ");
int[,] matrix = FillArray(rows, columns);
Console.WriteLine();
PrintArray(matrix);
SortingRows(matrix);
Console.WriteLine();
PrintArray(matrix);