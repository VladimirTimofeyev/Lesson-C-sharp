/*
10. Напиши программу, которая принимает на вход трехзначное число,
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8 
918 -> 1
*/

int val = new Random().Next(100, 10000);
System.Console.WriteLine(val);
if(val < 100)
{
    System.Console.WriteLine("Третьей цифры нет");
}
// int rev = 0;
while(val > 1000)
{
    val /= 10;
}
// while(val ! = 0)
//{
//   rev = rev * 10 + val % 10;
//   val /= 10;
//}
// string str = Convert.ToString(rev);
// string str = rev.ToString();
Console.WriteLine(val % 10);