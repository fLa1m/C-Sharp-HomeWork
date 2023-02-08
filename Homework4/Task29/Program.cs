// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void FillArray(int[] row)
{
    for (int i = 0; i < row.Length; i++)
    {
        row[i] = new Random().Next(50);
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1)
        {
            Console.Write($"{arr[i]}]");
        }
        else
        {
            Console.Write($"{arr[i]},");
        }
    }
}

Console.Clear();
int[] array = new int[8];
FillArray(array);
PrintArray(array);