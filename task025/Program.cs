// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// _____________________________________________________________________________________________________
// !!! Внимание! Считаем, что ноль входит в натуральный ряд. Поэтому степени считаем от 0. 

// Если не считать 0 натуральным числом, то условие цикла будет без -1, а счетчик будет начинаться с 1.  
// _____________________________________________________________________________________________________

Console.WriteLine("Введите первое целое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int numB = Convert.ToInt32(Console.ReadLine());

// Переменные для первых 2 решений.
// int multiplier = numA; //фиксируем первое число как множитель.
// int result = 1;

// 1. Решение через цикл while. 

// Условие i < numB (без =), т.к. считаем от нуля, а нам нужна степень именно введенного числа.
// Первоначально написал i <= numB-1 это тоже самое, но более громоздко.  

// int i = 0; 
// while (i < numB)
// {
//     result = multiplier * result;
//     i++;
// }
// Console.WriteLine($"Число {numA} в степени {numB} = {result}");

// 2. Решение через цикл for.

//for (int i = 0; i < numB; i++) result = multiplier * result;
//Console.WriteLine($"Число {numA} в степени {numB} = {result}");

// 3. Решение через метод.

int NumAToDegreeB(int a, int b)
{
    int res = 1;
    {
        for (int i = 0; i < b; i++) res = a * res;
    }
    return res;
}

int result = NumAToDegreeB(numA, numB);
Console.WriteLine($"Число {numA} в степени {numB} = {result}");
