// Задача №37
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний
// элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// Например:
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// Метод возвращает массив, заполненный случайными цифрами
int[] FillingArray()
{
    int[] outArray = new int[10];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < 10)
    {
        outArray[i] = numberSintezator.Next(-10, 10);
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

int[] CalculateTask(int[] inputArray)
{
    int[] resultArray = new int[inputArray.Length/2+1];
    int i = 0;

    while(i < resultArray.Length)
    {
        resultArray[i] = inputArray[i] * inputArray[inputArray.Length-1-i];  
        i++;
    }

    return resultArray;
}

int[] buferArray = FillingArray();
PrintIntArray(buferArray);
int[] resultArray = CalculateTask(buferArray);
PrintIntArray(resultArray);