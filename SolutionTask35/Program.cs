// Метод возвращает массив, заполненный случайными цифрами
int[] FillingArray()
{
    int[] outArray = new int[123];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < 123)
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

// Метод решения задачи 
int CalculateTask(int[] inputArray, int downBorder, int upBorder)
{
    int resultCount = 0;   // Переменная куда мы положим результат
    int i = 0;
    while(i < inputArray.Length)
    {
        if(inputArray[i] >= downBorder && inputArray[i] <= upBorder)
        {
            Console.Write(inputArray[i] + " ");
            resultCount++;
        }
        i++; 
    }
    return resultCount;
}

int[] buferArray = FillingArray();
PrintIntArray(buferArray);
Console.WriteLine(CalculateTask(buferArray, 10, 99));