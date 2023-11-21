/*
4. Напиши программу, которая на вход принимает число (number),
 а на выходе выводит все четные числа от 1 до number (включительно), разделеные знаком табуляции.

 number = 5 -> 2  4
 number = 8 -> 2  4  6  8 
*/

public class Answer
{
    static void PrintEvenNumbers(int number)
    {
        for (int count = 2; count <= number; count += 2)
        {
            Console.Write($"{count}\t");
        }
    }

    static public void Main(string[] args)
    {
        int number;

        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            number = 6;
        }
        PrintEvenNumbers(number);
    }
}