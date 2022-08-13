// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int IsPolyndromFiveDigit(int num) //метод определения полиндрома из 5 цифр.
{
    int res = -1; // задаем res = -1, что будет означать, что число не полиндром.
    int leftDigit = -1; //переменные для левой и правой цифры
    int rightDigit = -1;
    int numleft = num; // переменные для записи остатков от деления. Изначально равны введенному числу.
    int numright = num;
    int leftDivider = 10000; //делитель для нахождения левой цифры
    int rightDivider = 10; // делитель для нахождения правой цифры
    if (num < 0) num = num * -1; //переводим отрицательное введенное число в положительное (если отрицательные числа могут считаться полиндромами)
    if (num / leftDivider < 1 || num / leftDivider >= 10)
    //если после этого целая часть от деления на 10 000 < 1 или >= 10, то число не пятизначное, присваеваем этой ошибке код -2 и завершаем выполнение.
    {
        res = -2;
        return res;
    }
    while (leftDivider >= 100) //пока делитель с 10 000 не дойдет до 100, т.е. до середины числа.
    {
        if (leftDigit == rightDigit) // если первая и последняя цифра равны, выполняем.
        {
            leftDigit = numleft / leftDivider; //находим и сохраняем первую и последнюю цифры
            rightDigit = numright % rightDivider;
            numleft = numleft % leftDivider; //записываем остатки после деления и уменьшаем делитель, чтобы сдвинуться в разрядах числа
            numright = numright / rightDivider;
            leftDivider = leftDivider / 10; 
        }
        else return res; //если в какой-то момент первая цифра не равна второй, то выходим с кодом -1, не полиндром.
    }
    res = 1; //если цикл не прервался, то присваиваем код 1, число - полиндром.
    return res;
}
Console.WriteLine("Введите целое пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = IsPolyndromFiveDigit(number);

if (result == -2) Console.WriteLine($"Введенное число {number} не пятизначное!");
if (result == -1) Console.WriteLine($"Введенное число {number} не полиндром!");
if (result == 1) Console.WriteLine($"Введенное число {number} полиндром!");