// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

int[,] FillArray(int[] array)
{
    int[,] mainArray = new int[array[rows], array[columns]];
    for (int i = 0; i < array[rows]; i++)
    {
        for (int j = 0; j < array[columns]; j++)
        {
            mainArray[i, j] = new Random().Next(array[minValues], array[maxValues] + 1);
        }
    }
    return mainArray;
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

double[] ColumnAverage(int[,] array)
{
    double sumColumn = 0;
    double[] averageArray = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sumColumn += array[j, i];
        }
        averageArray[i] = Math.Round(sumColumn / array.GetLength(0), 1);
        sumColumn = 0;
    }
    return averageArray;
}

// Код
int[] arrayValue = InputArraySize("Введите параметры массива.");
int[,] array = FillArray(arrayValue);
PrintArray(array);
Console.WriteLine($"Среднее арифметическое каждого столбца: [{String.Join("; ", ColumnAverage(array))}]");