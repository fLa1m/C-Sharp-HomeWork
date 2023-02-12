// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int DataEntry(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

double[] GenerateArray(int length, int minValue, int maxValue)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = Math.Round(new Random().Next(minValue, maxValue + 1) + new Random().NextDouble(), 3);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}

double CompareArray(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        else if (array[i] > max)
        {
            max = array[i];
        }
    }
    double diffMaxMin = max - min;
    return diffMaxMin;
}

Console.Clear();
int length = DataEntry("Введите длину массива: ");
int min = DataEntry("Введите минимальное значение интервала: ");
int max = DataEntry("Введите максимальное значение интервала: ");
double[] arr = GenerateArray(length, min, max);
Console.WriteLine("Исходный массив:");
PrintArray(arr);
Console.WriteLine($"Разница между max и min элементами = {Math.Round(CompareArray(arr), 3)}");