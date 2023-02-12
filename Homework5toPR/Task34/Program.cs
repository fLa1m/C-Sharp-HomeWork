// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int DataEntry(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int[] GenerateArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 1000);
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
    Console.WriteLine($"{array[array.Length - 1]}]");
}

int EvenNum(int[] array)
{
    int count = 0;
    foreach (int i in array)
    {
        if (i % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.Clear();
int length = DataEntry("Введите длину массива: ");
int[] array = GenerateArray(length);
Console.WriteLine("Исходный массив:");
PrintArray(array);
Console.WriteLine($"Количество четных чисел в массиве: {EvenNum(array)}");