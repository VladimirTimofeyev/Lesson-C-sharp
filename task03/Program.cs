/*
3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница
*/

System.Console.WriteLine("Введите число:");
int weekDay = Convert.ToInt32(Console.ReadLine());

int day1 = 1;
int day2 = 2;
int day3 = 3; 
int day4 = 4;
int day5 = 5;
int day6 = 6;
int day7 = 7;

if (weekDay == day1) System.Console.WriteLine("Понедельник");
else if (weekDay == day2) System.Console.WriteLine("Вторник");
else if (weekDay == day3) System.Console.WriteLine("Среда");
else if (weekDay == day4) System.Console.WriteLine("Четверг");
else if (weekDay == day5) System.Console.WriteLine("Пятница");
else if (weekDay == day6) System.Console.WriteLine("Суббота");
else if (weekDay == day7) System.Console.WriteLine("Воскресенье");
else Console.WriteLine("Введено не верное число: ");
