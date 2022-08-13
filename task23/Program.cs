//  Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

double ThirdDeg (int num) 
//метод нахождения куба, тип Double из-за Math.Pow и того, что при поиске куба уже можно упереться в потолок int32
{
    return Math.Pow(num, 3); // вместо этого можно использовать num * num * num, но так короче.
}

Console.WriteLine("Введите целое число для получения таблицы кубов всех чисел от 1 до этого числа: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = number * -1; // по условиям задачи должно быть от 1 до N. Либо переводим в положительное, либо надо выводить ошибку ввода.

Console.WriteLine("__________________________");
Console.WriteLine("");
Console.WriteLine(" Число    |   Куб числа");
Console.WriteLine("__________________________");

int count = 1; 
double result = 1;
while (count <= number)
{
    result = ThirdDeg(count); //в цикле вызываем созданные метод и выводим на экран результат
    Console.WriteLine($"   {count}      |   {result} ");
    count++;
}