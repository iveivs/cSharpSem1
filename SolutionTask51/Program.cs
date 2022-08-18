// Задача №51
// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с
// индексами (0,0); (1;1)) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// Метод для заполнения двумерного массива cлучайными числами
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
            Console.Write(inputArray[i,j] + " ");
            j++;
        }
        // Console.Write("\n")
        Console.WriteLine();
        i++;
    }
    
}

int CalcDiagTwoDimArr (int[,] inputArray)
{
    int outSumDiag = 0;
    int i = 0;
    int j = 0;
    while(i < inputArray.GetLength(0))
    {
        j = 0;
        while(j < inputArray.GetLength(1))
        {
            if(i == j)
            {
                outSumDiag = outSumDiag + inputArray[i,j];
                //  outSumDiag += inputArray[i,j];
            }
            j++;
        }
        
        i++;
    }
    return outSumDiag;
}

// Или:

// int CalcDiagTwoDimArr (int[,] inputArray)
// {
//     int outSumDiag = 0;
//     int i = 0;
//     int j = 0;
//     while(i < inputArray.GetLength(0))
//     {
//         outSumDiag += inputArray[i,i];
//         i++;
//     }
//     return outSumDiag;
// }

int[,] twoDimArray = FillTwoDimArray(5,5);
PrintTwoDimArray(twoDimArray);
int sum = CalcDiagTwoDimArr(twoDimArray);
Console.WriteLine(sum);