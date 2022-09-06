// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 3 n = 2 -> A(m,n) = 29

Console.WriteLine("Введите первое целое не отрицательное число < 4:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое не отрицательное число:");
int numberN = Convert.ToInt32(Console.ReadLine());

int AckermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AckermanFunction(m - 1, 1);
    else return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}

if (numberM >= 4 && numberN > 0) Console.WriteLine("Ничего не выйдет, прощайте");
else
{
    int result = AckermanFunction(numberM, numberN);
    Console.WriteLine($"m = {numberM}, n = {numberN} -> A(m,n) = {result}");
}