// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int ShowSecondDigit(int num)
{
    int res = (num / 10) % 10;
    if (res < 0) //фикс для отрицательных чисел
    {
        res = res * -1;
    }
    return res;
}

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 999)
{
    Console.WriteLine("Вы ввели НЕ трехзначное число. Прощайте.");
}
else
{
    int secondDigit = ShowSecondDigit(number);
    Console.WriteLine($"Вторая цифра введенного числа {number} -> {secondDigit} ");
}


