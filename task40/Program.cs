/*
40. Напишите программу, которая принимает на вход три сисла и проверяет,
может ли существовать треугольник сос сторонами такой длины.
*/
/*
bool Triangle(int a, int b, int c)

{
    if(a + b > c & b + c > a & a + c > b)
    {
        return true;
    }
    return false;
}

System.Console.WriteLine(Triangle(1, 2, 3));
*/
string Triangle1(int a, int b, int c)
 {
    string result = $"Нет, такого треугольника";
    if(a + b > c & b + c > a & a + c > b)
    {
        result = $"Да, такой треугольник существует";
    }
    return result;
 }

System.Console.WriteLine(Triangle1(4, 2, 3));