/*
48. Задайте массив размера М на N,
каждый элемент в массиве находится по формуле A__ = M + N. Выведите полученный массив на экран.
*/

Console.Clear();

int[,] GetRnd(int rows, int colom)
{
    int[,] array = new int[rows, colom];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}


void PrintMatrix(int[,] arr)
{
    Console.ForegroundColor = ConsoleColor.Green;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    Console.ForegroundColor = ConsoleColor.Green;
    Console.ResetColor();
}

int[,] ArrayMtrix = GetRnd(3,3);
PrintMatrix(ArrayMtrix);