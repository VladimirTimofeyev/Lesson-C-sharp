/*
25. Напишите цикл который принимает на вход два числа (А и В) и возводит
 число А в натуральную степень В.
*/

System.Console.WriteLine(Pow(3,5));

int Pow(int number, int degree)
{
    int temp = number;
    while(degree > 1)
    {
        number *= temp;
        degree--;
    }
    return number;
}