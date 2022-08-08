// Задача №32
// Напишите программу замена элементов массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// Пример:
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

// Метод печатает массив
void PrintIntArray(int[] inputArray)
{
    // Буфферная переменная
    int i = 0;
    // Пробегаем все элементы массива
    while(i < inputArray.Length - 1)
    {
        // Выводим элемент массива
        Console.Write(inputArray[i] + ", ");
        // Увеличиваем инкримент
        i++;
    }
    // Выводим элемент массива
    Console.WriteLine(inputArray[i]);
}


// Метод инвертирует элементы массива(- меняет на  + и наоборот)
int[] CalculateTask(int[] inputArray)
{
    // Объявляем буферный массив
    int[] outputArray = new int[12];
    int i = 0;
    while(i < 12)
    {
        outputArray[i] = inputArray[i] * (-1);
        i++; 
    }
    return outputArray;
}

int[] bufferArray = FillingArray();
PrintIntArray(bufferArray);
int[] resultArray = CalculateTask(bufferArray);
PrintIntArray(resultArray);