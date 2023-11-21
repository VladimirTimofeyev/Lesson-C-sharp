/*
1. Напишите программу, которая на вход принимает два числа и проверяет,
 является ли первое число квадратом второго.

 а = 25; и = 5 -> да
 а = 2 b = 10 -> нет
 a = 9; b = -3 -> да
 a = -3 b = 9 -> нет
*/

System.Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 / number2 == number2 || number2 / number1 == number1)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

