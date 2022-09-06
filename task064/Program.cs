// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Clear();
Console.WriteLine("Введите целое число:");
int numberN = Convert.ToInt32(Console.ReadLine());

void NaturalNumberRowReverse(int n)
{
    if (n == 0) return;
    if (n == 1) Console.Write($"{n}"); // чтобы не было запятой после 1.
    else
    {
        Console.Write($"{n}, ");
        NaturalNumberRowReverse(n - 1);
    }
}

Console.Write($"N = {numberN} -> ");
NaturalNumberRowReverse(numberN);