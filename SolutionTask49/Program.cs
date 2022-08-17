// Задача №49
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти
// элементы на их квадраты. Например:
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4


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

int[,] UpdateTwoDimArray(int[,] inputArray)
{
    int[,] outArray = new int[inputArray.GetLength(0),inputArray.GetLength(1)]; // Создаём буфферный массив
    int i = 0;
    int j = 0;
    while(i < inputArray.GetLength(0))
    {
        j = 0;
        while(j < inputArray.GetLength(1))
        {
            if(i % 2 == 0 && j % 2 == 0)
            {
            outArray[i,j] = inputArray[i,j] * inputArray[i,j];
            }
            else
            {
                outArray[i,j] = inputArray[i,j];
            }
            j++;
        }
        
        i++;
    }
    return outArray;
}

int[,] twoDimArray = FillTwoDimArray(5,8);
PrintTwoDimArray(twoDimArray);
PrintTwoDimArray(UpdateTwoDimArray(twoDimArray));
