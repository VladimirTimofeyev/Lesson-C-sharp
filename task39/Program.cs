/*
39. Напишите программу, которая перевернет одномерный массив (последний элемент будет на первом месте,
 а первый на последнем и т.д.)
*/

int[] array = {1,2,3};

foreach(int i in array) System.Console.Write(i + " ");



void ArrayReverse(int[] arr)
{
    int temp = arr[0];

    for(int i = 0, j = arr.Length - 1; i < arr.Length - 2; i++, j--)
        arr[i] = arr[j];

    arr[arr.Length-1] = temp;    
}