/*
13. Напиши программу, которая выводит третью цифру заданного числа
 или сообщает, что третьей цифры нет.
645 ->5
78 -> третьей цифры нет
32679 -> 6
*/

int number = new Random().Next(100, 1000);
System.Console.WriteLine(number);
int[] array = { number };

int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    // index = index + 1
    index++;
}