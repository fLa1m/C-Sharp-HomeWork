//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, 
//  y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// y = ax + c; y = bx + d; (d - c/a - b; ad - bc/a - b)

double InputNum(string message)
{
    Console.Write(message);
    double num = double.Parse(Console.ReadLine());
    return num;
}

string CrossPoint(double a, double b, double c, double d)
{
    double pointOne = (d - c) / (a - b);
    double pointTwo = (a * d - b * c) / (a - b);
    string point = "(" + pointOne + "; " + pointTwo + ")";
    return point;
}

Console.Clear();
double k1 = InputNum("Задайте значение k1: ");
double b1 = InputNum("Задайте значение b1: ");
double k2 = InputNum("Задайте значение k2: ");
double b2 = InputNum("Задайте значение b2: ");
Console.WriteLine($"Точка пересечения прямых: {CrossPoint(k1, k2, b1, b2)}");