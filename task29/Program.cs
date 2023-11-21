/*
29. Напишите программу, которая задает массив из 8-ми элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] array = CreateArray(3, 0, 34);

Print(array);


int[]CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    var random = new Random();

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, maxValue);
    }

    return array;
}
void Print(int[]array)
{
    foreach(int i in array)
       System.Console.Write(i + " ");
}