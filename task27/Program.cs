/*
27. Напишите программу, которая принимает на вход число и выдает сумму цифр в числе. 
*/

System.Console.WriteLine(SumOfDigits(452));

int SumOfDigits(int num)
{
    num = Math.Abs(num);
    int result = 0;
    while(num > 0)
    {
        result += num % 10;
        num /= 10;
    }
    return result;

}