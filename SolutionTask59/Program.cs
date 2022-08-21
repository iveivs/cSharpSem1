﻿// Задача 59. Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и солбец,
// на пересечении которых расположен наименьший элемент массива.

int[,] FillTwoDimArray(int countRow, int countColumn)
{
    System.Random numberSintezator = new System.Random();

    int i = 0;
    int j = 0;
    int[,] outArray = new int[countRow, countColumn];
    while(i < countRow)
    {
        j = 0;
        while(j < countColumn)
        {
            outArray[i,j] = numberSintezator.Next(0,100);
            j++;
        }
        i++;
    }
    return outArray;
}

// Метод вывода массива на печать
void PrintTwoDimArray(int[,] inputArray)
{
    int i = 0;
    int j = 0;
    while(i < inputArray.GetLength(0))
    {
        j = 0;
        while(j < inputArray.GetLength(1))
        {
            Console.Write(inputArray[i,j] + "\t");
            j++;
        }
        // Console.Write("\n")
        Console.WriteLine();
        i++;
    }
}

int[,] Update2_DArray(int[,] inputArray, int row, int column)
{
    int[,] outArray = new int[inputArray.GetLength(0)-1, inputArray.GetLength(1)-1];
    int i = 0; int j = 0;
    int k = 0; int m = 0;
    while (i < inputArray.GetLength(0))
    {
        j = 0; m = 0;
        while (j < inputArray.GetLength(1))
        {
            if (i != row && j != column)
            {
                outArray[k, m] = inputArray[i, j];
            }
            if(j != column)m++;
            j++;
        }
        if(i != row)k++;
        i++;
    }
    return outArray;
}

int[] FindMinElement(int[,] matrix)
{
    // Уменьшаем выдаваемый массив
    int[] array = new int[] {0, 0};
    // вводим минимальный элемент и задаём переменной максимальное значение
    int minElement = int.MaxValue;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] < minElement)
            {
                minElement = matrix[i,j];
                array[0] = i;
                array[1] = j;
            }
        }
    }
    return array;
}

int[,] twoDimArray = FillTwoDimArray(5,5);
PrintTwoDimArray(twoDimArray);
Console.WriteLine();

int[] indexes = FindMinElement(twoDimArray);
Console.WriteLine(indexes[0]+" "+indexes[1]);

int[,] buferTwoDimArray = Update2_DArray(twoDimArray, indexes[0], indexes[1]);
PrintTwoDimArray(buferTwoDimArray);