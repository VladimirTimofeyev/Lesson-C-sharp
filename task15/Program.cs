/*
15.Напиши программу, которая показывает будний или выходной день.

*/

System.Console.WriteLine("Введите номер дня недели (от 1 до 7): ");

int dayOfWeek = int.Parse(Console.ReadLine());

if (dayOfWeek < 1 || dayOfWeek > 7) System.Console.WriteLine("Вы ввели неверное число");
if (dayOfWeek > 0 && dayOfWeek < 6) System.Console.WriteLine("Это будний день");
if (dayOfWeek > 5 && dayOfWeek < 8) System.Console.WriteLine("Это выходной день");