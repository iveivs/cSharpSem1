// Задача №33
// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в
// массиве. Например:
//  4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// Метод возвращает массив, заполненный случайными цифрами(в диапазоне от -9 до 9)
int[] FillingArray()
{
    int[] outArray = new int[12];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < 12)
    {
        outArray[i] = numberSintezator.Next(-9,10);
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

// Метод решения задачи 33
bool CalculateTask(int[] inputArray, int searchNumber)
{
    bool resultSearch = false;   // Переменная куда мы положим результат
    int i = 0;
    while(i < 12)
    {
        if(inputArray[i] == searchNumber)
        {
            resultSearch = true;
            break; 
        }
        i++; 
    }
    return resultSearch;
}

int[] buferArray = FillingArray();
PrintIntArray(buferArray);
Console.WriteLine("Введите число для поиска: ");
int searchNumber = int.Parse(Console.ReadLine());
Console.WriteLine(CalculateTask(buferArray,searchNumber));