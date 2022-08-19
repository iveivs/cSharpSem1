// Задача 53.   Задайте двумерный массив. Напишите программу, которая поменяет местами
// первую и последнюю строку массива. Например:
// 1 4 2             6 8 8 
// 3 1 9   а будет   3 1 9  
// 6 8 8             1 4 2 

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
            Console.Write(inputArray[i,j] + "\t");
            j++;
        }
        // Console.Write("\n")
        Console.WriteLine();
        i++;
    }
}
// Метод, который меняет местами первую строчку с последней
// Принимает двумерный массив
// Возвращает модифицированный входной массив
int[,] RotateRowFirstLast (int[,] inputArray)
{
    int bufferElement = 0;
    int i = 0;
    int j = 0;
    while(j < inputArray.GetLength(1))
        {
            bufferElement = inputArray[0,j];       
            inputArray[0,j] = inputArray[inputArray.GetLength(0)-1,j];
            inputArray[inputArray.GetLength(0)-1,j] = bufferElement;
            j++;
        }
        return inputArray;
}

int[,] twoDimArray = FillTwoDimArray(3,5);
PrintTwoDimArray(twoDimArray);

Console.WriteLine();

PrintTwoDimArray(RotateRowFirstLast(twoDimArray ));