/*
69. Напишите программу которая принимает на вход два числа
А и В, и возводит число А в целую степень спомощью рекурсии.
*/

Console.Clear();

int Step(int digit, int square)
{
    if (square == 1)
    {
        return digit;
    }
    else
    {
        return digit * Step(digit, square - 1);
        //num % 10 + Summ(num/10);
    }
}
int result = Step(3, 3);
System.Console.WriteLine(result);