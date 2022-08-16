// Задача №48
// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ =
// m+n. Выведите полученный массив на экран.
// Пример: m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

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

void UpdateTwoDimArray(ref int[,] inputArray)
{
    int i = 0;
    int j = 0;
    while(i < inputArray.GetLength(0))
    {
        j = 0;
        while(j < inputArray.GetLength(1))
        {
            inputArray[i,j] = i + j;
            j++;
        }
        
        i++;
    }
}

int[,] twoDimArray = FillTwoDimArray(5,8);
PrintTwoDimArray(twoDimArray);
UpdateTwoDimArray(ref twoDimArray);
PrintTwoDimArray(twoDimArray);