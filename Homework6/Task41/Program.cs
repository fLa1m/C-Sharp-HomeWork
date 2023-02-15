//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

string[] InputArray(string message)
{
    Console.Write(message);
    string[] str = Console.ReadLine().Split(" "); // добавление в массив по разделителю
    return str;
}

int[] ChangeType(string[] array)
{
    int[] numArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        numArray[i] = int.Parse(array[i]);
    }
    return numArray;
}

Console.Clear();
string[] inputNum = InputArray("Введите числа через пробел: ");
int[] array = ChangeType(inputNum);
int count = 0;
for (int i = 0; i < inputNum.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество чисел > 0: {count}");