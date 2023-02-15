// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Enter the ratio k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the coefficient b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the ratio k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the coefficient b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

if (k1==k2)
{
    Console.WriteLine("The Lines are parallel and have no crosspoint");
}
if (b1==b2)
{
    Console.WriteLine($"The crosspoint is (0,{b1})");
}
if (k1!=k2 && b1!=b2)
{
    double x = (b1-b2) / (k2-k1);
    double y = k2*x + b2;

    Console.WriteLine($"The crosspoint is ({x},{y})");
}