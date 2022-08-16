// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// Например: m = 3, n = 4.
// -1  4  8 19
//  5 -2 33 -2
// -77 3  8  1


// Метод для заполнения двумерного массива
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

int[,] twoDimArray = FillTwoDimArray(5,8);
PrintTwoDimArray(twoDimArray);