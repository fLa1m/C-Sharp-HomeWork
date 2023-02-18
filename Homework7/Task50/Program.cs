// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> по такому индексу нет элемента.

const int row = 0;
const int column = 1;

// Методы
int DataInput(string message)
{
    int value;
    do
    {
        Console.Write(message);
        int.TryParse(Console.ReadLine(), out value);
        if (value < 0) { Console.WriteLine("Введите значение > 0."); }
    } while (value < 0);
    return value;
}

int[] PositionsOfElement(string message)
{
    Console.Clear();
    int[] elementPosition = new int[2];
    Console.WriteLine(message);
    Console.WriteLine("-------------");
    elementPosition[row] = DataInput("Ряд: ");
    elementPosition[column] = DataInput("Столбец: ");
    return elementPosition;
}

int[,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(-100, 101);
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

bool FindPosition(int[] positionArray, int[,] originalArray)
{
    if (positionArray[row] < originalArray.GetLength(0)
        && positionArray[column] < originalArray.GetLength(1))
    {
        return true;
    }
    else { return false; }
}

// Код
int[,] array = CreateArray(3, 4);
int[] position = PositionsOfElement("Введите позицию элемента.");
Console.WriteLine("-------------");
PrintArray(array);
Console.WriteLine("-------------");
if (FindPosition(position, array))
{
    Console.WriteLine($"Элемент на позиции [{String.Join(", ", position)}] = {array[position[row], position[column]]}");
}
else { Console.WriteLine($"Элемента на позции [{String.Join(", ", position)}] - нет"); }