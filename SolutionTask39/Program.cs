﻿// Задача №39
// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на
// первом месте, а первый - на последнем и т.д.)
// Например:
// [1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6]
// Комментарий: эту задачу можно решить 2 способами: 1) менять числа местами в исходном массиве; 2) создать
// новый массив и в него записать перевёрнутый исходный массив по элементам.

// Метод возвращает массив, заполненный случайными цифрами
int[] FillingArray(int arrayLength)
{
    int[] outArray = new int[arrayLength];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < arrayLength)
    {
        outArray[i] = numberSintezator.Next(-1000, 1000);
        i++;
    } 
    return outArray;
}

// Печатаем массив
void PrintIntArray(int[] inputArray)
{
    int i = 0;
    while(i < inputArray.Length - 1)
    {
        Console.Write(inputArray[i] + ", ");
        i++;
    }
    Console.WriteLine(inputArray[i]);
}

int[] ReverseNewArray(int[] array)
{
    int length = array.Length;
    int[] newArray = new int[length];

    for (int i = 0; i < length; i++)
    {
        newArray[length - 1 - i] =  array[i];
    }
    return newArray;
}


int[] ReverseSwapArray(int[] array)
{
    int length = array.Length;
    int buf;

    for (int i = 0; i < length/2; i++)
    {
        buf = array[i];
        array[i] = array[length - 1 - i];
        array[length -1 - i] = buf;
    }
    return array;
}


int[] testArray = FillingArray(13);
PrintIntArray(testArray);
int[] reversedArray = ReverseNewArray(testArray);
PrintIntArray(reversedArray);
PrintIntArray(ReverseSwapArray(testArray));
PrintIntArray(testArray);