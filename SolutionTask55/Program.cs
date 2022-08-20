// Задача 55. Задайте двумерный массив . Напишите программу, которая заменяет строки на столбцы
// В случае если это не возможно , программа должна вывести сообщение для пользователя.

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
int[,] RotateTwoDimArray (int[,] inputArray)
{
    int bufferElement = 0;
    int i = 0;
    int j = 0;
    while(i < inputArray.GetLength(0))
        {
            j = i;
            while(j < inputArray.GetLength(0))
            {
                bufferElement = inputArray[i,j];       
                inputArray[i,j] = inputArray[j,i];
                inputArray[j,i] = bufferElement;
                j++;
            }
            i++;
        }
        return inputArray;
}

int[,] twoDimArray = FillTwoDimArray(3,3);
PrintTwoDimArray(twoDimArray);
Console.WriteLine();

if(twoDimArray.GetLength(0) != twoDimArray.GetLength(1))
{
    Console.WriteLine("Данный массив перевернуть нельзя!");
}
else
{
    PrintTwoDimArray(RotateTwoDimArray(twoDimArray));
}





