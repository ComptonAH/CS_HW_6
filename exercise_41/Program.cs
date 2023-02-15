// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Enter the length of array you want to fill: ");

int[] Array = new int[Convert.ToInt32(Console.ReadLine())];

for (int i = 0, sum = 0; i <= Array.Length; i++)
{
    if (i == Array.Length)
    {
        Console.WriteLine($"The number of the values greater than zero is {sum}"); 
        break;
    }
    Console.Write($"Enter a value of {i} element: "); 
    Array[i] = Convert.ToInt32(Console.ReadLine());
    if (Array[i]>0) sum += 1;
}