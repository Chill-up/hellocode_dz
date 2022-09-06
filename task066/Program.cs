// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// m и n даны включительно.

Console.WriteLine("Введите первое целое число:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число:");
int numberN = Convert.ToInt32(Console.ReadLine());

int FindSumBetweenTwoIntNUmbers(int m, int n)
{
    int sum = m;
    if (m < n - 1) return sum += FindSumBetweenTwoIntNUmbers(m + 1, n);
    if (m > n + 1) return sum += FindSumBetweenTwoIntNUmbers(m - 1, n);
    else return m + n;
}

int result = FindSumBetweenTwoIntNUmbers(numberM, numberN);
Console.WriteLine($"Сумма чисел от M = {numberM} до N = {numberN} (включительно) -> {result}");