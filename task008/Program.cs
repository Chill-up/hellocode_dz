// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Все четные числа от 1 до {number} это: ");
int even = 1;
while (even <= number)
{
    if (even % 2 == 0)
    {
        Console.Write(even + " ");
    }
        even = even + 1;
}
