/*
5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает
 все целые числа от -N до N.

4 ->"-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 ->" -2, -1, 0, 1, 2"
*/
System.Console.WriteLine("Введите число: ");
int number = int.Parse(System.Console.ReadLine());

System.Console.WriteLine($"Целые числа в диапазоне от {-number} до {number} ");

for(int i = -number; i < number + 1; i++) {System.Console.Write(i + " ");}