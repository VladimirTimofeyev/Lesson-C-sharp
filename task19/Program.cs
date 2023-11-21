/*
19. Напиши программу, которая принимает на входе пятезначное число (number) 
и проверяет, является ли оно палиндромом.
14212 -> False
12821 -> True
234322 -> Число не пятезначное
*/

Console.Clear();
/*
System.Console.WriteLine("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n / 10000;
int n2 = n / 1000 % 10;
int n4 = n / 10 % 10;
int n5 = n % 10;

if (n >- 10000 & n <- 99999)
{
    if (n1 == n5 & n2 == n4)
    {
        System.Console.Write("Yes");
    }
    else
    System.Console.Write("No");
}
else
{
    System.Console.WriteLine("Here's not five digit.");
}
*/
System.Console.WriteLine("Enter number: ");
int N = Convert.ToInt32(Console.ReadLine());
int revN = 0;
for (int i = N; i > 0; i /= 10)
{
    revN = revN * 10 + i % 10;
    //System.Console.WriteLine(revN);
}
if (N == revN)
    System.Console.WriteLine("Yes");
    else System.Console.WriteLine("No");