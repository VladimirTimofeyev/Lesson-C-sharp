/*
23. Написать метод ShowCube, который принимает
на вход число (N) и выводит таблицу кубов чисел от 1 до N
(включительно) каждое на новой строке.

N = 3 -> 1: 8: 27:
N = 5 -> 1: 8: 27: 64: 125
*/

Console.Clear();
System.Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
if (userNumber < 0)
{
    userNumber = userNumber * -1;
}
for (int i = 1; i < userNumber + 1; i++)
{
    System.Console.Write(i * i * i);
    if (i < userNumber)
    {
        System.Console.Write(", ");
    }
}