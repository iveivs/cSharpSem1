// Задача № 31
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например:
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма
// отрицательных равна -20.

// Решение:

// Переменные для накопления результата

int positiveSum = 0;
int negativeSum = 0;

// Метод возвращает массив заполненный случайными цифрами от -9 о 9
int[] FillingArray()
{
    // Выходной массив
    int[] outArray = new int[12];
    // Буфферная переменная 
    int i = 0;
    // Создаём экземпляр класса рандомайзер
    System.Random numberSintezator = new System.Random();
    // Цикл заполнения массива
    while (i < 12)
    {
        // Получаем новое значение
        outArray[i] = numberSintezator.Next(-9,10);
        // Увеличиваем инкремент
        i++;
    } 
    // Возвращаем значение
    return outArray;
}

// Метод подсчёта положительных и отрицательных чисел
void CalculateTask(int[] outArray)
{
    int i = 0;
    while(i < 12)
    {
        if(outArray[i] > 0)
        {
            positiveSum += outArray[i];
        }
        else
        {
            negativeSum += outArray[i];
        }
        i++;
    }
}

//  Выводим результат на консоль
void PrintResult()
{
    Console.WriteLine(positiveSum);
    Console.WriteLine(negativeSum);
}

// Метод решения задачи
void VariantNative()
{
    int [] bufferArray = FillingArray();
    CalculateTask(bufferArray);
    PrintResult();
}

VariantNative();