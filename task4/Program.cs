// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье целое число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int maxnumber = number1;

if (maxnumber < number2)
{
    maxnumber = number2;
}
if (maxnumber < number3)
{
    maxnumber = number3;
}
// не знаю насколько корректно писать if без else, но программа работает)
// проверял в том числе на наборе отрицательных чисел с нулем: -3, 0, -5
Console.Write($"Максимальное число из введенных {number1},{number2},{number3} это -> {maxnumber} ");