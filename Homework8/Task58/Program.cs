// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixMultiplication(int[,] arrayA, int[,] arrayB)
{
    int[,] multMatrix = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    int mult = 0;
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayA.GetLength(0); k++)
            {
                mult = arrayA[i, k] * arrayB[k, j];
                multMatrix[i, j] += mult;
            }
            mult = 0;
        }
    }
    return multMatrix;
}

int a, b, c, d;
a = DataInput("Введите количество строк матрицы А: ");
do
{
    b = DataInput("Введите количество столбцов матрицы А: ");
    c = DataInput("Введите количество строк матрицы B: ");
    if (b != c) { Console.WriteLine("Количестов столбцов матрицы A должно быть равно количеству строк матрицы B."); }
} while (b != c);
d = DataInput("Введите количество столбцов матрицы B: ");

int[,] matrixA = FillArray(a, b);
int[,] matrixB = FillArray(c, d);
PrintArray(matrixA);
Console.WriteLine();
PrintArray(matrixB);
int[,] matrixAB = MatrixMultiplication(matrixA, matrixB);
Console.WriteLine();
PrintArray(matrixAB);