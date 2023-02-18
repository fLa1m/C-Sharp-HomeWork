// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

const int rows = 0;
const int columns = 1;
const int minValues = 2;
const int maxValues = 3;

// Методы
int DataInput(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int[] InputArraySize(string message)
{
    Console.Clear();
    int[] arraySize = new int[4];
    Console.WriteLine(message);
    Console.WriteLine("-------");
    arraySize[rows] = DataInput("Введите количетсво строк: ");
    arraySize[columns] = DataInput("Введите количество столбцов: ");
    arraySize[minValues] = DataInput("Введите начало интервала: ");
    arraySize[maxValues] = DataInput("Введите конец интервала: ");
    return arraySize;
}

double[,] FillArray(int[] array)
{
    double[,] realArray = new double[array[rows], array[columns]];
    for (int i = 0; i < array[rows]; i++)
    {
        for (int j = 0; j < array[columns]; j++)
        {
            realArray[i, j] = new Random().Next(array[minValues], array[maxValues])
                + Math.Round(new Random().NextDouble(), 1);
        }
    }
    return realArray;
}

void PrintArray(double[,] array)
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

// Код
int[] arrayValue = InputArraySize("Введите параметры массива.");
double[,] array = FillArray(arrayValue);
PrintArray(array);